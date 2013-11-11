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
        public Mode ControlMode { get; private set; }

        private string name;
        public string RoundName
        {
            get { return name; }
            set { name = value; roundGroup.ValuesPrimary.Heading = value; }
        }

        #endregion

        #region fields
        private Round _round; 
        #endregion

        #region ctor
        public RoundCtrl()
        {
            InitializeComponent();

            ControlMode = Mode.MatchPlayersStance;
            Dock = DockStyle.Fill;
        }

        public RoundCtrl(Round matchRound)
        {
            InitializeComponent();

            ControlMode = Mode.RoundStance;
            Dock = DockStyle.Fill;

            _round = matchRound;
        } 
        #endregion

        internal void AddControl(Control ctrl)
        {
            tableLayout.SuspendLayout();


            tableLayout.Controls.Add(ctrl);

            tableLayout.ResumeLayout();
        }


        public void ClearPlayers()
        {
            tableLayout.Controls.Clear();
        }

        public void AddPlayerCtrl(Player player)
        {
            if (ControlMode != Mode.MatchPlayersStance)
                return;
            tableLayout.Controls.Add(new PlayerPositionCtrl(player));
        }

        public void AddPlayerPair(PlayerStance player1, PlayerStance player2)
        {
            if (ControlMode != Mode.RoundStance)
                return;
            //tableLayout.Controls.Add(playerCtrl);
        }
    }
}
