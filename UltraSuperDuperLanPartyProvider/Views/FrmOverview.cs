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

namespace UltraSuperDuperLanPartyProvider.Views
{
    public partial class FrmOverview : Form
    {
        private IGamerCollection gamers;
        private BindingSource blueBs;
        private BindingSource redBs;

        public FrmOverview(ref IGamerCollection gamers)
        {
            InitializeComponent();
            this.gamers = gamers;
            this.blueBs = new BindingSource();
            this.redBs = new BindingSource();
            this.dgvBlue.AutoGenerateColumns = false;
            this.dgvRed.AutoGenerateColumns = false;
            InitializeBlue();
            InitializeRed();
        }

        public void Reset()
        {
            InitializeBlue();
            InitializeRed();
        }

        private void InitializeBlue()
        {
            this.dgvBlue.AutoGenerateColumns = false;
            this.dgvRed.AutoGenerateColumns = false;
            blueBs.DataSource = gamers.DataSource.Where(x => x.IsPresent && x.Team == Gamer.TeamType.Blue);
            dgvBlue.DataSource = blueBs;
        }

        private void InitializeRed()
        {
            this.dgvBlue.AutoGenerateColumns = false;
            this.dgvRed.AutoGenerateColumns = false;
            redBs.DataSource = gamers.DataSource.Where(x => x.IsPresent == true && x.Team == Gamer.TeamType.Red);
            dgvRed.DataSource = redBs;
        }

        private void dgvBlue_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBlue[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "blueScore")
            {
                string value = dgvBlue[e.ColumnIndex, e.RowIndex].Value.ToString();
                if (value.Contains("+"))
                {
                    try
                    {
                        value = (Convert.ToInt32(value.Split('+')[0]) + Convert.ToInt32(value.Split('+')[1])).ToString();
                        dgvBlue[e.ColumnIndex, e.RowIndex].Value = value;
                    }
                    catch (Exception ex)
                    {
                        blueBs.CancelEdit();
                    }
                }
            }
            blueBs.EndEdit();
            gamers.Save();
        }

        private void dgvRed_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRed[e.ColumnIndex, e.RowIndex].OwningColumn.Name == "redScore")
            {
                string value = dgvRed[e.ColumnIndex, e.RowIndex].Value.ToString();
                if (value.Contains("+"))
                {
                    try
                    {
                        value = (Convert.ToInt32(value.Split('+')[0]) + Convert.ToInt32(value.Split('+')[1])).ToString();
                        dgvRed[e.ColumnIndex, e.RowIndex].Value = value;
                    }
                    catch (Exception ex)
                    {
                        redBs.CancelEdit();
                    }
                }
            }
            redBs.EndEdit();
            gamers.Save();
        }
    }
}
