using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tournamenter_WinFormsApp
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private RoundCtrl ActiveRound { get { return _rounds.Count > 0 ? _rounds.Last() : _startList; } }

        #region fields

        private readonly List<RoundCtrl> _rounds = new List<RoundCtrl>();

        private PlayerListFrm _playerListFrm;

        private Match _match;
        private readonly RoundCtrl _startList = new RoundCtrl();
        private RoundCtrl _endList;

        #endregion fields

        #region ctor

        public MainForm()
        {
            InitializeComponent();

            statusTime.Text = DateTime.Now.ToString("h:mm:ss   d MMMM yyyy");
            statusLabel.Text = "Ready";

            _playerListFrm = new PlayerListFrm(this);
            _playerListFrm.Location = new Point(Screen.FromControl(this).WorkingArea.Size - this.Size);

            tableLayout.Controls.Add(_startList);

            SetMenuAndToolboxItems(MatchStatus.NotSet);
        }

        #endregion ctor

        private void playerList_Click(object sender, EventArgs e)
        {
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

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void matchSettings_Click(object sender, EventArgs e)
        {
            if (_match == null)
                return;
            using (MatchSettingsFrm frm = new MatchSettingsFrm(_match.Settings, _match.Status != MatchStatus.PlayersEnlisting))
            {
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
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            e.Effect = DragDropEffects.Link;
            AddPlayerToMatch(player);
        }

        #region Match GUI -> Logic

        private void newMatch_Click(object sender, EventArgs e)
        {
            if (_match != null && !_match.CanCloseSafe &&
                MessageBox.Show(this,
                "There is already match in progress. Are you sure you want to quit it and start new match?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            if (_match != null)
                RestartMatchUI();

            using (MatchSettingsFrm frm = new MatchSettingsFrm(MatchSettings.DefaultSettings, false))
            {
                frm.ShowDialog(this);
                _match = Match.CreateNewMatch(frm.Settings);
            }

            InitMatchGUI();

            btnPlayerList.PerformClick();
        }

        private void InitMatchGUI()
        {
            _startList.Visible = true;

            _startList.RoundName = _match.Name;
            _match.PlayerAdded += matchPlayerAdded;
            _match.MatchStatusChanged += matchStatusChanged;
            _match.RoundAdded += matchRoundAdded;

            _match.RaiseMatchStatusChanged();
        }

        private void RestartMatchUI()
        {
            string result;
            if (_match != null)
            {
                _match.AutoSave(out result);//???

                _match.PlayerAdded -= matchPlayerAdded;
                _match.MatchStatusChanged -= matchStatusChanged;
                _match.RoundAdded -= matchRoundAdded;
                _match = null;
            }

            tableLayout.Controls.Clear();

            _startList.ClearPlayers();
            if (_endList != null)
                _endList.ClearPlayers();
            _endList = null;

            tableLayout.Controls.Add(_startList);
        }

        private void matchRoundAdded(object sender, Round e)
        {
            RoundCtrl roundCtrl = new RoundCtrl(e);
            tableLayout.Controls.Add(roundCtrl);

            if (e.Status == RoundStatus.MatchResult)
                _endList = roundCtrl;

            SetStatus("Round {0} started", e.Number);
        }

        private void matchStatusChanged(object sender, MatchStatus e)
        {
            switch (e)
            {
                case MatchStatus.PlayersEnlisting:
                    SetStatus("Add players to match");
                    break;

                case MatchStatus.RoundStarted:
                    SetStatus("Round started");
                    break;

                case MatchStatus.RoundClosed:
                    SetStatus("Round closed");
                    break;

                case MatchStatus.MatchEnded:

                    break;

                default:
                    break;
            }
            SetMenuAndToolboxItems(e);
        }

        private void matchPlayerAdded(object sender, Player e)
        {
            _startList.AddPlayerCtrl(e);
        }

        internal void AddPlayerToMatch(Player player)
        {
            if (_match == null)
            {
                MessageBox.Show(this, "No match started. Cannot add player now");
                return;
            }

            if (_match.Status != MatchStatus.PlayersEnlisting)
            {
                MessageBox.Show(this, "Cannot add player now");
                return;
            }

            if (!_match.AddPlayer(player))
                MessageBox.Show(this, string.Format("Player {0} is already added to match.", player));
        }

        private void SetMenuAndToolboxItems(MatchStatus status)
        {
            menuStrip.SuspendLayout();

            //match
            btnNewMatch.Enabled = true;
            tsBtnNewMatch.Enabled = true;
            btnStartMatch.Enabled = true;
            btnCloseRound.Enabled = true;

            btnSaveMatch.Enabled = true;
            tsBtnSaveMatch.Enabled = true;
            btnSaveMatchAs.Enabled = true;
            btnOpenMatch.Enabled = true;
            tsBtnOpenMatch.Enabled = true;
            btnPrintMatch.Enabled = true;
            tsBtnPrintMatchState.Enabled = true;
            btnPrintMatchPreview.Enabled = true;

            btnMatchSettings.Enabled = true;
            //general settings
            btnPlayerList.Enabled = true;
            btnOptions.Enabled = true;

            switch (status)
            {
                case MatchStatus.PlayersEnlisting:
                    btnNewMatch.Enabled = false;
                    tsBtnNewMatch.Enabled = false;
                    btnCloseRound.Enabled = false;
                    break;

                case MatchStatus.RoundStarted:
                    btnNewMatch.Enabled = false;
                    tsBtnNewMatch.Enabled = false;
                    btnStartMatch.Enabled = false;
                    break;

                case MatchStatus.RoundTimeEnded:
                    btnNewMatch.Enabled = false;
                    tsBtnNewMatch.Enabled = false;
                    btnStartMatch.Enabled = false;
                    break;

                case MatchStatus.RoundClosed:
                    btnNewMatch.Enabled = false;
                    tsBtnNewMatch.Enabled = false;
                    btnStartMatch.Enabled = false;
                    btnCloseRound.Enabled = false;
                    break;

                case MatchStatus.MatchEnded:
                case MatchStatus.NotSet:
                default:
                    btnStartMatch.Enabled = false;
                    btnCloseRound.Enabled = false;
                    btnSaveMatch.Enabled = false;
                    tsBtnSaveMatch.Enabled = false;
                    btnSaveMatchAs.Enabled = false;
                    btnPrintMatch.Enabled = false;
                    tsBtnPrintMatchState.Enabled = false;
                    btnPrintMatchPreview.Enabled = false;

                    btnMatchSettings.Enabled = false;
                    break;
            }
            menuStrip.ResumeLayout();
        }

        #endregion Match GUI -> Logic

        private void startMatch_Click(object sender, EventArgs e)
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

        private void closeRound_Click(object sender, EventArgs e)
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

        #region Help

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Tournamenter by Misiek", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpContents_Click(object sender, EventArgs e)
        {
        }

        #endregion Help

        #region Logging/Status change

        private void SetStatus(string text, params object[] args)
        {
            statusLabel.Text = string.Format(text, args);
        }

        #endregion Logging/Status change

        #region Save/Load

        private void saveMatchStatus_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = string.Format(
                "Match{0}_Round{1}.xml", _match.Name, _match.ActiveRoundCount);

            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            string result;
            if (_match.Save(saveFileDialog.FileName, out result))
                SetStatus(String.Format("Match file saved to: {0}", result));
            else
                SetStatus(String.Format("Match saving operation failed: {0}", result));
        }

        private void loadMatch_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            string result;
            Match match = Match.Load(openFileDialog.FileName, out result);
            if (match == null)
            {
                SetStatus(String.Format("Match loading operation failed: {0}", result));
                return;
            }

            RestartMatchUI();

            _match = match;

            InitMatchGUI();

            foreach (var player in _match.Players)
            {
                matchPlayerAdded(_match, player);
            }

            foreach (var round in _match.Rounds)
            {
                matchRoundAdded(_match, round);
            }

            matchStatusChanged(_match, _match.Status);

            SetStatus(String.Format("Match file loaded from: {0}", result));
        }

        #endregion Save/Load

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

        #endregion test code
    }
}