using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dynamsoft.Barcode;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using UltraSuperDuperLanPartyProvider.Interfaces;
using GenCode128;
using UltraSuperDuperLanPartyProvider.Views;

namespace UltraSuperDuperLanPartyProvider
{
    public partial class FrmMain : Form
    {
        private FilterInfoCollection videoCaptureDevices;
        private VideoCaptureDevice finalVideoSource;
        private Bitmap image;
        private Config config;
        private Gamer gamer;
        private IGamerCollection gamers;
        private BindingSource gamersbs;


        public FrmMain()
        {
            InitializeComponent();
            FormClosing += FrmMain_FormClosing;
            KeyPreview = true;

            config = new Config();
            gamer = new Gamer();
            gamers = new GamerCollection();
            gamersbs = new BindingSource();

            StartStream();
            InitializeCamSelector();
            InitializeGamersBox();

            FrmOverview fo = new FrmOverview();
            fo.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopStream();
        }

        private void StartStream()
        {
            if (!String.IsNullOrEmpty(config.Webcam))
            {
                videoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                finalVideoSource = new VideoCaptureDevice(config.Webcam);
                finalVideoSource.NewFrame += new NewFrameEventHandler(FinalVideoSource_NewFrame);
                finalVideoSource.Start();
            }
            else
            {
                MessageBox.Show("Geen webcam geconfigureerd");
            }
        }

        private void StopStream()
        {
            if (finalVideoSource != null)
            {
                finalVideoSource.Stop();
            }
        }

        private void FinalVideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            image = (Bitmap)eventArgs.Frame.Clone();
            pbStream.Image = image;
        }

        private void ReadBarcode(Bitmap bitmap)
        {
            BarcodeReader bcReader = new BarcodeReader();
            TextResult[] results = bcReader.DecodeBitmap(bitmap, "reader");

            lblWelcome.Text = "";
            if (results == null)
            {
                lblWelcome.Text = "Geen barcode herkend!";
                return;
            }

            foreach (TextResult result in results)
            {
                lblWelcome.Text += result.BarcodeText;
            }
        }

        private void pnlTop_MouseDoubleClick(object sender, MouseEventArgs e)
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
        }

        private void InitializeCamSelector()
        {
            if(videoCaptureDevices == null)
            {
                videoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            }
            foreach (FilterInfo VideoCaptureDevice in videoCaptureDevices)
            {
                cbSelectCam.Items.Add(VideoCaptureDevice.MonikerString);
            }
        }

        private void InitializeGamersBox()
        {
            gamersbs.DataSource = gamers.DataSource;
            lbGamers.DisplayMember = "Name";
            lbGamers.ValueMember = "Id";
            lbGamers.DataSource = gamersbs;
        }

        private void btnSaveGamer_Click(object sender, EventArgs e)
        {
            if (txtGamerName.Text != "")
            {
                Gamer gamer = new Gamer();
                gamer.Id = DateTime.Now.Ticks;
                gamer.Name = txtGamerName.Text;
                gamers.Add(gamer);
                gamers.Save();
                gamersbs.ResetBindings(false);
            }

            txtGamerName.Text = "";
            txtGamerName.Select();
            txtGamerName.Focus();
        }

        private void btnStartStream_Click(object sender, EventArgs e)
        {
            StopStream();
            StartStream();
        }

        private void lbGamers_KeyDown(object sender, KeyEventArgs e)
        {
            if (lbGamers.SelectedItem != null && e.KeyCode == Keys.Delete)
            {
                gamers.Remove((long)lbGamers.SelectedValue);
                gamers.Save();
                gamersbs.ResetBindings(false);
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

        private void btnSaveCam_Click(object sender, EventArgs e)
        {
            config.Webcam = cbSelectCam.SelectedItem.ToString();
        }
    }
}
