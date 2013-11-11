using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Logic;

namespace Tournamenter_WinFormsApp
{
    public partial class MatchSettingsFrm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public MatchSettingsFrm()
        {
            InitializeComponent();
        }

        public MatchSettingsFrm(MatchSettings settings) : this()
        {
            matchSettingsBindingSource.DataSource = settings;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void SetReadonly()
        {
            pointsForBayTextBox.ReadOnly = true;
            pointsForDrawTextBox.ReadOnly = true;
            walkowerPointsTextBox.ReadOnly = true;
            roundCountTextBox.ReadOnly = true;
        }
    }
}