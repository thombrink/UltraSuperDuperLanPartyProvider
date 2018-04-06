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
            blueBs.DataSource = gamers.DataSource.Where(x => x.IsPresent == true && x.Team == Gamer.TeamType.Blue);
            dgvBlue.DataSource = blueBs;
        }

        private void InitializeRed()
        {
            redBs.DataSource = gamers.DataSource.Where(x => x.IsPresent == true && x.Team == Gamer.TeamType.Red);
            dgvRed.DataSource = redBs;
        }


    }
}
