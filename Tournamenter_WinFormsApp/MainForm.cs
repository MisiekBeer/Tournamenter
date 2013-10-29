using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Tournamenter_WinFormsApp
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private List<RoundCtrl> _rounds = new List<RoundCtrl>();

        public MainForm()
        {
            InitializeComponent();
        }

        public void AddStartPlayers()
        {
            var startPlayers = new RoundCtrl();
            startPlayers.AddControl(new PlayerPositionCtrl());
            startPlayers.AddControl(new PlayerPositionCtrl());
            startPlayers.AddControl(new PlayerPositionCtrl());
            startPlayers.AddControl(new PlayerPositionCtrl());
            startPlayers.AddControl(new PlayerPositionCtrl());
            startPlayers.AddControl(new PlayerPositionCtrl());
            startPlayers.AddControl(new PlayerPositionCtrl());
            startPlayers.AddControl(new PlayerPositionCtrl());
            startPlayers.AddControl(new PlayerPositionCtrl());
            startPlayers.AddControl(new PlayerPositionCtrl());

            startPlayers.Height = tableLayout.Height;
            tableLayout.Controls.Add(startPlayers);
        }

        public void AddRoundPlayers()
        {
            var startPlayers = new RoundCtrl();

            var vsctrl = new VsCtrl(new PlayerPositionCtrl(), new PlayerPositionCtrl());
            startPlayers.AddControl(new VsCtrl(new PlayerPositionCtrl(), new PlayerPositionCtrl()));
            startPlayers.AddControl(new VsCtrl(new PlayerPositionCtrl(), new PlayerPositionCtrl()));
            startPlayers.AddControl(new VsCtrl(new PlayerPositionCtrl(), new PlayerPositionCtrl()));
            startPlayers.AddControl(new VsCtrl(new PlayerPositionCtrl(), new PlayerPositionCtrl()));
            startPlayers.AddControl(new VsCtrl(new PlayerPositionCtrl(), new PlayerPositionCtrl()));
            startPlayers.AddControl(new VsCtrl(new PlayerPositionCtrl(), new PlayerPositionCtrl()));
            startPlayers.AddControl(new VsCtrl(new PlayerPositionCtrl(), new PlayerPositionCtrl()));
            startPlayers.AddControl(new VsCtrl(new PlayerPositionCtrl(), new PlayerPositionCtrl()));

            startPlayers.Height = tableLayout.Height;
            startPlayers.Width = vsctrl.Width;
            tableLayout.Controls.Add(startPlayers);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayout.SuspendLayout();

            AddStartPlayers();

            tableLayout.ResumeLayout();
           
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            //foreach (var ctrl in _rounds)
            //{
            //    ctrl.Height = tableLayout.Height;
            //}
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayout.SuspendLayout();

            AddRoundPlayers();

            tableLayout.ResumeLayout();
        }

        private void playerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new PlayerListFrm();
            frm.Show(this);
        }
        
    }
}