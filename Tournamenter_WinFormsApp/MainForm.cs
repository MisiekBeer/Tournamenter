using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Logic;
using System.Linq;
using System.Linq.Expressions;

namespace Tournamenter_WinFormsApp
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        RoundCtrl ActiveRound { get { return _rounds.Count > 0 ? _rounds.Last() : _startList; } }

        #region fields
        private readonly List<RoundCtrl> _rounds = new List<RoundCtrl>();

        private PlayerListFrm _playerListFrm;

        private Match _match;
        private readonly RoundCtrl _startList = new RoundCtrl();
        private RoundCtrl _endList;
        #endregion

        #region ctor
        public MainForm()
        {
            InitializeComponent();

            statusTime.Text = DateTime.Now.ToString("h:mm:ss   d MMMM yyyy");
            statusLabel.Text = "Ready";

            _playerListFrm = new PlayerListFrm(this);
            _playerListFrm.Location = new Point(Screen.FromControl(this).WorkingArea.Size - this.Size);

            tableLayout.Controls.Add(_startList);
        } 
        #endregion

        #region test code

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

            tableLayout.Controls.Add(startPlayers);
        }

        private void printMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayout.SuspendLayout();

            AddStartPlayers();

            tableLayout.ResumeLayout();
        }

        private void printMatchPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayout.SuspendLayout();

            AddRoundPlayers();

            tableLayout.ResumeLayout();
        }

        #endregion

        private void playerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<PlayerListFrm>().Count() > 0)
                _playerListFrm.Activate();
            else
                _playerListFrm.Show(this);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            statusTime.Text = DateTime.Now.ToString("h:mm:ss   d MMMM yyyy");
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (_match != null && !_match.CanCloseSafe &&
                MessageBox.Show(this,
                "There is already match in progress. Are you sure you want to quit?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;

            base.OnClosing(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            int statusWidth = statusStrip.ClientSize.Width;
            statusWidth -= statusProgress.Width + statusRound.Width + statusTime.Width + 50;

            if (statusWidth >= 50)
                statusLabel.Width = statusWidth;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void matchSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_match == null || _match.Status != MatchStatus.PlayersEnlisting)
                return;
            using (MatchSettingsFrm frm = new MatchSettingsFrm(_match.Settings))
            {
                //frm.SetReadonly();
                frm.ShowDialog(this);
            }
        }

        private void tableLayout_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void tableLayout_DragDrop(object sender, DragEventArgs e)
        {
            Player player = e.Data.GetData(typeof(Player)) as Player;
            if (player == null || _match == null || _match.Status != MatchStatus.PlayersEnlisting)
                return;

            AddPlayerToMatch(player);
        }

        #region Match GUI -> Logic
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_match != null && !_match.CanCloseSafe &&
                MessageBox.Show(this,
                "There is already match in progress. Are you sure you want to quit it and start new match?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            if (_match != null)
                RestartMatch();

            MatchSettings settings = new MatchSettings();
            using (MatchSettingsFrm frm = new MatchSettingsFrm(settings))
            {
                frm.ShowDialog(this);
            }

            _match = Match.CreateNewMatch();
            _startList.Visible = true;

            _startList.RoundName = _match.Name;
            _match.PlayerAdded += _match_PlayerAdded;
            _match.MatchStatusChanged += _match_MatchStatusChanged;
            _match.RoundAdded += _match_RoundAdded;

            matchSettingsToolStripMenuItem.Visible = true;
            playerListToolStripMenuItem.PerformClick();
        }

        void _match_RoundAdded(object sender, Round e)
        {
            tableLayout.Controls.Add(new RoundCtrl(e));
        }

        void _match_MatchStatusChanged(object sender, MatchStatus e)
        {
            switch (e)
            {
                case MatchStatus.PlayersEnlisting:

                    break;
                case MatchStatus.RoundStarted:
                    break;
                case MatchStatus.RoundEnded:
                    break;
                case MatchStatus.MatchEnded:

                    break;
                default:
                    break;
            }
        }

        private void _match_PlayerAdded(object sender, Player e)
        {
            _startList.AddPlayerCtrl(e);
        }

        private void RestartMatch()
        {
            _match.Save();
            _match.PlayerAdded -= _match_PlayerAdded;
            _match.MatchStatusChanged -= _match_MatchStatusChanged;
            _startList.ClearPlayers();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        } 

        internal void AddPlayerToMatch(Player player)
        {
            if (_match == null)
                return;

            if (_match.Status != MatchStatus.PlayersEnlisting)
                MessageBox.Show(this, "Cannot add player now");

            if (!_match.AddPlayer(player))
                MessageBox.Show(this, string.Format("Player {0} is already added to match.", player));
        } 
        #endregion

        private void startMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_match == null || _match.Status != MatchStatus.PlayersEnlisting)
            {
                MessageBox.Show(this, "Cannot start match now.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_match.PlayerCount < 3)
            {
                MessageBox.Show(this, "You need more players to start.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RoundCtrl roundCtrl = new RoundCtrl(_match.StartMatch());
            _rounds.Add(roundCtrl);
            tableLayout.Controls.Add(roundCtrl);
        }

        private void closeRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_match == null || _match.Status != MatchStatus.RoundStarted)
            {
                MessageBox.Show(this, "No active round now to close.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ActiveRound.CheckIfAllPointsEntered())
            {
                MessageBox.Show(this, "Please enter all player's results.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _match.CloseRoundAndGenerateNext();
        }


    }
}