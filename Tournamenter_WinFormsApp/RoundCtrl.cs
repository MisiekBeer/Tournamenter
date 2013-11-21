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
            /// Start or end
            /// </summary>
            MatchPlayersStance,
            /// <summary>
            /// match rounds
            /// </summary>
            RoundStance
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

            ControlMode = Mode.MatchPlayersStance;
        }

        /// <summary>
        /// Round player vs player container.
        /// </summary>
        /// <param name="matchRound">current round</param>
        public RoundCtrl(Round matchRound)
        {
            Initialize();

            ControlMode = Mode.RoundStance;

            _round = matchRound;

            AddVsControls();
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
                AddPlayerPair(pair.Item1, pair.Item2);
            }
        }

        public void ClearPlayers()
        {
            _posControls.Clear();
            tableLayout.Controls.Clear();
        }

        public void AddPlayerCtrl(Player player)
        {
            if (ControlMode != Mode.MatchPlayersStance)
                return;

            var ctrl = new PlayerPositionCtrl(player);
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
