using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Tournamenter_WinFormsApp
{
    public partial class RoundCtrl : UserControl
    {
        public enum Mode
        {
            /// <summary>
            /// Start
            /// </summary>
            StartingRound,
            /// <summary>
            /// match rounds
            /// </summary>
            RoundStance,
            /// <summary>
            /// Finished match players positions
            /// </summary>
            EndRound
        }

        #region props
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public Mode ControlMode { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string RoundName
        {
            get { return roundGroup.ValuesPrimary.Heading; }
            set { roundGroup.ValuesPrimary.Heading = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string RoundDescription
        {
            get { return roundGroup.ValuesSecondary.Heading; }
            set { roundGroup.ValuesSecondary.Heading = value; }
        }

        #endregion

        #region fields
        private Round _round;
        private readonly List<PlayerPositionCtrl> _posControls = new List<PlayerPositionCtrl>();
        #endregion

        #region ctor
        /// <summary>
        /// Player list constructor. For adding single player controls
        /// </summary>
        public RoundCtrl()
        {
            Initialize();

            ControlMode = Mode.StartingRound;
            RoundName = "Match players";
            RoundDescription = "Add players and select start match.";
        }

        /// <summary>
        /// Round player vs player container.
        /// </summary>
        /// <param name="matchRound">current round</param>
        public RoundCtrl(Round matchRound)
        {
            Initialize();

            ControlMode = (matchRound.Status == RoundStatus.MatchResult) ? 
                Mode.EndRound : Mode.RoundStance;

            _round = matchRound;

            switch (ControlMode)
            {
                case Mode.EndRound:
                    RoundName = "Match ended";
                    RoundDescription = "Players match results.";
                    foreach (PlayerStance player in _round.PlayerPlaces)
                    {
                        AddPlayerCtrl(player);
                    }
                    break;
                
                case Mode.RoundStance:
                default:
                    RoundName = string.Format("Round: {0}", matchRound.Number);
                    RoundDescription = string.Format("Round: {0} player points.", matchRound.Number);
                    AddVsControls();
                    break;
            }

        }

        private void Initialize()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        #endregion

        internal void AddControl(Control ctrl)
        {
            tableLayout.SuspendLayout();


            tableLayout.Controls.Add(ctrl);

            tableLayout.ResumeLayout();
        }

        private void AddVsControls()
        {
            foreach (var pair in _round.PlayerPairs)
            {
                AddPlayerPair(pair.Player1, pair.Player2);
            }
        }

        public void ClearPlayers()
        {
            _posControls.Clear();
            tableLayout.Controls.Clear();
        }

        public void AddPlayerCtrl(Player player)
        {
            if (ControlMode != Mode.StartingRound)
                return;

            var ctrl = new PlayerPositionCtrl(player);
            _posControls.Add(ctrl);
            tableLayout.Controls.Add(ctrl);
        }

        public void AddPlayerCtrl(PlayerStance player)
        {
            if (ControlMode != Mode.EndRound)
                return;

            var ctrl = new PlayerPositionCtrl(player, true);
            _posControls.Add(ctrl);
            tableLayout.Controls.Add(ctrl);
        }

        private void AddPlayerPair(PlayerStance player1_Stance, PlayerStance player2_Stance)
        {
            if (ControlMode != Mode.RoundStance)
                return;

            var ctrl1 = new PlayerPositionCtrl(player1_Stance);
            var ctrl2 = new PlayerPositionCtrl(player2_Stance);
            _posControls.Add(ctrl1);
            _posControls.Add(ctrl2);
            tableLayout.Controls.Add(new VsCtrl(ctrl1, ctrl2));
        }

        public bool CheckIfAllPointsEntered()
        {
            switch (ControlMode)
            {
                case Mode.RoundStance:
                    return _posControls.All(n => n.PointsEntered == true);
                default:
                    return false;
            }
        }
    }
}
