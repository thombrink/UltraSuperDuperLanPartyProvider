using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltraSuperDuperLanPartyProvider.Interfaces;
using GenCode128;
using UltraSuperDuperLanPartyProvider.Views;

namespace UltraSuperDuperLanPartyProvider
{
    public partial class FrmMain : Form
    {
        private Gamer gamer;
        private IGamerCollection gamers;
        private BindingSource gamersBs;
        private Timer timer;
        private FrmOverview fo;
        private string lastId;


        public FrmMain()
        {
            InitializeComponent();
            KeyPreview = true;
            FormClosing += FrmMain_FormClosing;

            gamer = new Gamer();
            gamers = new GamerCollection();
            gamersBs = new BindingSource();

            InitializeGamersBox();
            SetState(State.Awaiting);

            UpdateOverview();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            gamers.Save();
        }

        private void pnlTop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            InitiateInputBox();
        }

        private void InitializeGamersBox()
        {
            gamersBs.DataSource = gamers.DataSource;
            lbGamers.DisplayMember = "Name";
            lbGamers.ValueMember = "Id";
            lbGamers.DataSource = gamersBs;
        }

        private void InitiateInputBox()
        {
            txtInput.Text = "";
            txtInput.Select();
            txtInput.Focus();
        }

        private void btnSaveGamer_Click(object sender, EventArgs e)
        {
            if (txtGamerName.Text != "" && cbPaid.SelectedItem.ToString() != "")
            {
                Gamer gamer = new Gamer
                {
                    Id = DateTime.Now.Ticks,
                    Name = txtGamerName.Text,
                    HasPaid = (cbPaid.SelectedItem.ToString() == "Ja") ? true : false
                };
                gamers.Add(gamer);
                gamers.Save();
                gamersBs.ResetBindings(false);
                UpdateOverview();
            }

            txtGamerName.Text = "";
            txtGamerName.Select();
            txtGamerName.Focus();
        }
        private void lbGamers_KeyDown(object sender, KeyEventArgs e)
        {
            if (lbGamers.SelectedItem != null && e.KeyCode == Keys.Delete)
            {
                DialogResult dialogResult = MessageBox.Show("Weet je zeker dat je de gamer wilt verwijderen?", "Verwijderen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    gamers.Remove((long)lbGamers.SelectedValue);
                    gamers.Save();
                    gamersBs.ResetBindings(false);
                    UpdateOverview();
                }
            }
        }

        private void lbGamers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lbGamers.SelectedItem != null)
                {
                    var img = Code128Rendering.MakeBarcodeImage(lbGamers.SelectedValue.ToString(), 3, true);
                    Clipboard.SetImage(img);
                    MessageBox.Show("Barcode op het klembord geplaatst!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Text);
            }
        }

        private void pnlConfig_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnlTop_MouseDoubleClick(sender, e);
        }

        private void pbStream_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pnlConfig.Visible)
            {
                pnlConfig.Visible = false;
            }
            else
            {
                pnlConfig.Visible = true;
            }
            pnlConfig.Update();
            InitiateInputBox();
        }

        #region Scan input

        private void ProcessInput(string value, bool shorten = false)
        {
            try
            {
                long id = (shorten) ? Convert.ToInt64(value.Substring(0, 15)) : Convert.ToInt64(value);
                gamer = gamers.Get(id);

                if (gamer != null)
                {
                    State state = State.Awaiting;

                    if (gamer.IsPresent)
                    {
                        gamer.IsPresent = false;
                    }
                    else
                    {
                        gamer.IsPresent = true;
                    }

                    if (String.IsNullOrEmpty(gamer.Nickname) && gamer.IsPresent)
                    {
                        state = State.Recognized;
                    }
                    else
                    {
                        state = State.Processed;
                    }
                    gamers.Update(gamer);
                    gamers.Save();
                    SetState(state);
                    UpdateOverview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Scan input

        #region States

        public enum State
        {
            Awaiting = 0,
            Recognized = 1,
            Processed = 2
        }
        private void SetState(State state)
        {
            switch (state)
            {
                case State.Awaiting:
                    SetAwaitingState();
                    break;
                case State.Recognized:
                    SetRecognizedState();
                    break;
                case State.Processed:
                    SetProcessedState();
                    break;
                default:
                    SetAwaitingState();
                    break;
            }
        }

        private void SetAwaitingState()
        {
            pnlTop.Visible = true;
            txtNickname.Text = "";
            lblWelcome.Text = "Hallo daar, scan hier je barcode!";
            pbStream.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStream.Image = Properties.Resources.wallpaper;
            pnlBottom.Visible = false;
            InitiateInputBox();
            UpdateOverview();
        }

        private void SetRecognizedState()
        {
            lblWelcome.Text = $"{gamer.Name}, mooi dat je er bij bent!";
            pbStream.SizeMode = PictureBoxSizeMode.CenterImage;
            pbStream.Image = Properties.Resources.checkmark;
            pnlBottom.Visible = true;
            txtNickname.Focus();
            this.ActiveControl = txtNickname;
            UpdateOverview();
        }

        private void SetProcessedState()
        {
            pbStream.SizeMode = PictureBoxSizeMode.CenterImage;
            pbStream.Image = Properties.Resources.checkmark;
            pnlTop.Visible = false;
            pnlBottom.Visible = false;
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateOverview();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SetState(State.Awaiting);
            timer.Stop();
        }

        #endregion States

        private void btnSaveNickName_Click(object sender, EventArgs e)
        {
            if (txtNickname.Text == lastId)
            {
                txtNickname.Text = "";
            }
            if (!String.IsNullOrEmpty(txtNickname.Text))
            {
                gamer.Nickname = txtNickname.Text;
                gamers.Update(gamer);
                gamers.Save();
                SetState(State.Processed);
            }
        }

        private void txtNickname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveNickName_Click(sender, e);
            }
        }

        private void btnResetState_Click(object sender, EventArgs e)
        {
            SetState(State.Awaiting);
            UpdateOverview();

        }

        private void UpdateOverview()
        {
            if (fo != null && !fo.IsDisposed)
            {
                fo.Reset();
            }
            else
            {
                fo = new FrmOverview(ref gamers);
                fo.Show();
            }
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtInput.Text.Length == 18)
            {
                ProcessInput(txtInput.Text);
                lastId = txtInput.Text;
                txtInput.Text = "";
            }
        }

        private void btnRandomizeTeam_Click(object sender, EventArgs e)
        {
            gamers.RandomizeTeams();
            UpdateOverview();
        }

        private void pnlBottom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                SetState(State.Awaiting);
            }
        }
    }
}
