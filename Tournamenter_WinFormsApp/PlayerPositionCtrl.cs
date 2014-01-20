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
                if (_player == Player.Empty || _playerStance == PlayerStance.Empty) 
                    return true;
                return _playerStance != null && _valueEntered; } }
        #endregion

        private enum PlayerPosCtrlMode
        {
            NotSet,
            EnterPlayer,
            RoundPointsEdit,
            MatchEndResult
        }

        #region fields
        private Player _player;
        private PlayerStance _playerStance;

        private PlayerPosCtrlMode _workingMode;
        private bool _valueEntered;
        #endregion

        #region ctor
        public PlayerPositionCtrl()
        {
            InitializeComponent();

            SetWorkingMode(PlayerPosCtrlMode.NotSet);

        }

        public PlayerPositionCtrl(PlayerStance playerStance, bool lastRound = false)
        {
            InitializeComponent();

            if (lastRound)
                SetWorkingMode(PlayerPosCtrlMode.MatchEndResult);
            else
                SetWorkingMode(PlayerPosCtrlMode.RoundPointsEdit);

            _playerStance = playerStance;
            if (_playerStance == PlayerStance.Empty)
                _player = Player.Empty;

            bindSrcPlayerStance.DataSource = _playerStance;

            if (_playerStance == PlayerStance.Empty)
            {
                _valueEntered = true;
                DisablePointsShow();
            }
        }

        public PlayerPositionCtrl(Player player)
        {
            InitializeComponent();

            SetWorkingMode(PlayerPosCtrlMode.EnterPlayer);

            if (player == null)
                throw new ArgumentNullException("Null player in control");
            
            _player = player;
            if (_player == Player.Empty)
                _playerStance = PlayerStance.Empty;

            tbImie.Text = _player.Name;
            tbKsywa.Text = _player.Nick;
            tbNazwisko.Text = _player.Surname;
        }

        private void SetWorkingMode(PlayerPosCtrlMode mode)
        {
            _workingMode = mode;

            switch (mode)
            {
                case PlayerPosCtrlMode.EnterPlayer:
                    btValEnteredChk.Visible = false;
                    DisablePointsShow();
                    break;

                case PlayerPosCtrlMode.RoundPointsEdit:
                    btValEnteredChk.Visible = true;
                    break;

                case PlayerPosCtrlMode.MatchEndResult:
                    btValEnteredChk.Visible = false;
                    break;
            }
        }

        private void DisablePointsShow()
        {
            SuspendLayout();

            groupPunkty.Visible = false;
            this.Height = Height - groupPunkty.Height;
            groupPunkty.Height = 1;

            ResumeLayout();
        }

        #endregion

        private void labelPosition_TextChanged(object sender, EventArgs e)
        {
            if (labelPosition.Text == "0" || labelPosition.Text == "-1" ||
                labelPosition.Text == "00" || labelPosition.Text == "-1")
                labelPosition.Text = "BAY";
        }

        private void tbSmallPoints_ValueChanged(object sender, EventArgs e)
        {
            btValEnteredChk.Enabled = true;
        }

        private void btValEnteredChk_Click(object sender, EventArgs e)
        {
            _valueEntered = btValEnteredChk.Checked;
        }


    }
}
