using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Tournamenter_WinFormsApp
{
    public partial class PlayerPositionCtrl : UserControl
    {
        #region props
        public PlayerStance Stance { get { return _playerStance; } }
        public bool PointsEntered { 
            get {
                if (_player == Player.Empty) return true;
                return _playerStance != null && _playerStance.PointsEntered; } }
        #endregion

        #region fields
        private Player _player;
        private PlayerStance _playerStance; 
        #endregion

        #region ctor
        public PlayerPositionCtrl()
        {
            InitializeComponent();
        } 
        #endregion

        public PlayerPositionCtrl(Player player)
        {
            InitializeComponent();

            if (player != Player.Empty)
                SetShowPoints(false);

            _player = player;

            tbImie.Text = _player.Name;
            tbKsywa.Text = _player.Nick;
            tbNazwisko.Text = _player.Surname;
        }

        public PlayerPositionCtrl(PlayerStance playerStance)
        {
            InitializeComponent();

            _playerStance = playerStance;

            bindSrcPlayerStance.DataSource = _playerStance;
        }

        private void SetShowPoints(bool _showPoints)
        {
            SuspendLayout();

            groupPunkty.Visible = false;
            this.Height = Height - groupPunkty.Height;
            groupPunkty.Height = 1;

            ResumeLayout();
        }

        private void labelPosition_TextChanged(object sender, EventArgs e)
        {
            if (labelPosition.Text == "0" || labelPosition.Text == "-1" ||
                labelPosition.Text == "00" || labelPosition.Text == "-1")
                labelPosition.Text = "BAY";
        }


    }
}
