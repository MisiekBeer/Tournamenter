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
    public partial class PlayerListFrm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public enum EditKind
        {
            None,
            Add,
            Change,
            Remove
        }

        #region fields
        private Player _selectedPlayer;
        private EditKind _editKind = EditKind.None;

        private MainForm _parentFrm;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        #endregion

        #region ctor
        public PlayerListFrm()
        {
            InitializeComponent();
            dgvPlayers.AutoGenerateColumns = true;
            BlockEditors(true);
        }

        public PlayerListFrm(MainForm parent) : this()
        {
            _parentFrm = parent;
            RefreshList();

            PlayerList.Instance.PropertyChanged += Instance_PropertyChanged;

#if !DEBUG
            btnAddDebugPlayers.Visible = false;
#endif
        }
        #endregion

        void Instance_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            dgvPlayers.DataSource = PlayerList.Instance.Players;
            dgvPlayers.Refresh();
        }

        private void PlayerListFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PlayerList.Instance.PropertyChanged -= Instance_PropertyChanged;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);

            this.Hide();
        }

        private void dgvPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 0)
            {
                _selectedPlayer = null;
                return;
            }
            _selectedPlayer = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;

            SetPlayerEditorsData(_selectedPlayer);
        }


        private void SetPlayerEditorsData(Player player)
        {
            playerIdTextBox.Text = player.PlayerId.ToString();
            nameTextBox.Text = player.Name;     
            surnameTextBox.Text = player.Surname;    
            nickTextBox.Text = player.Nick; 
            infoTextBox.Text = player.Info;       
            tagTextBox.Text = player.Tag;      
        }

        private void SetPlayerDataFromEditors(Player player)
        { 
            player.Name = nameTextBox.Text;
            player.Surname = surnameTextBox.Text;
            player.Nick = nickTextBox.Text;
            player.Info = infoTextBox.Text;
            player.Tag = tagTextBox.Text;
        }

        private void ClearEditors()
        {
            playerIdTextBox.Clear();
            nameTextBox.Clear();
            surnameTextBox.Clear();
            nickTextBox.Clear();
            infoTextBox.Clear();
            tagTextBox.Clear();      
        }

        private void BlockEditors(bool blockEditors)
        {
            nameTextBox.ReadOnly =
            surnameTextBox.ReadOnly =
            nickTextBox.ReadOnly =
            infoTextBox.ReadOnly =
            tagTextBox.ReadOnly = blockEditors;      
        }

        private bool ValidateEditors()
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show(this, "Player name empty!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(surnameTextBox.Text))
            {
                MessageBox.Show(this, "Player surname empty!");
                return false;
            }
            return true;
        }

        private void btnEditOK_Click(object sender, EventArgs e)
        {
            switch (_editKind)
            {
                case EditKind.Add:
                    if (!ValidateEditors()) 
                        return;
                    Player player = new Player();
                    SetPlayerDataFromEditors(player);
                    PlayerList.Instance.Add(player);

                    ClearEditors();
                    dgvPlayers.Rows[dgvPlayers.Rows.Count - 1].Selected = true;
                    labelStatus.Text = string.Format("Player: {0} added", player);
                    break;

                case EditKind.Change:
                    if (_selectedPlayer == null)
                    {
                        MessageBox.Show("Player not selected.");
                        break;
                    }
                    if (!ValidateEditors())
                        return;
                    SetPlayerDataFromEditors(_selectedPlayer);
                    labelStatus.Text = string.Format("Player: {0} edited", _selectedPlayer);
                    PlayerList.Instance.SavePlayerList();
                    dgvPlayers.Refresh();
                    break;

                case EditKind.Remove:
                    if (_selectedPlayer == null)
                    {
                        MessageBox.Show("Player not selected.");
                        break;
                    }
                    PlayerList.Instance.Remove(_selectedPlayer);
                    labelStatus.Text = string.Format("Player: {0} removed", _selectedPlayer);
                    _selectedPlayer = null;

                    ClearEditors();
                    dgvPlayers.Rows[dgvPlayers.Rows.Count - 1].Selected = true;
                    break;

                default:
                    ClearEditors();
                    break;
            }
            _editKind = EditKind.None;
            checkSet.CheckedButton = null;
            BlockEditors(true);
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            checkSet.CheckedButton = null;
            _selectedPlayer = null;
            BlockEditors(true);
            labelStatus.Text = "Operation cancelled";
        }

        private void checkSet_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (checkSet.CheckedButton != null)
                EnableEditMenuItems(false);

            if (checkSet.CheckedButton == checkBtnAddPlayer)
            {
                _editKind = EditKind.Add;
                ClearEditors();
                BlockEditors(false);
                labelStatus.Text = "Add player mode";
                return;
            }
            if (checkSet.CheckedButton == checkButtonEditPlayer)
            {
                _editKind = EditKind.Change;
                BlockEditors(false);
                labelStatus.Text = "Edit player mode";
                return;
            }
            if (checkSet.CheckedButton == checkButtonRemovePlayer)
            {
                _editKind = EditKind.Remove;
                BlockEditors(true);
                labelStatus.Text = "Remove player mode";
                return;
            }

            _editKind = EditKind.None;
            EnableEditMenuItems(true);
        }

        #region tool strip methods
        private void EnableEditMenuItems(bool editEnabled)
        {
            newPlayerToolStripMenuItem.Enabled =
            editPlayerToolStripMenuItem.Enabled =
            deletePlayerToolStripMenuItem.Enabled = editEnabled;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBtnAddPlayer.PerformClick();
        }

        private void editPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkButtonEditPlayer.PerformClick();
        }

        private void removePlayerStripMenuItem_Click(object sender, EventArgs e)
        {
            checkButtonRemovePlayer.PerformClick();
        } 
        #endregion

        private void btnAddToMatch_Click(object sender, EventArgs e)
        {
            if (_selectedPlayer == null)
            {
                MessageBox.Show(this, "Select player to add");
                return;
            }
            _parentFrm.AddPlayerToMatch(_selectedPlayer);
            labelStatus.Text = string.Format("Player {0} added to match", _selectedPlayer);

        }

        #region Drag&Drop
        private void dgvPlayers_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = dgvPlayers.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dgvPlayers_MouseMove(object sender, MouseEventArgs e)
        {
            if (!e.Button.HasFlag(MouseButtons.Left))
                return;

            // If the mouse moves outside the rectangle, start the drag.
            if (dragBoxFromMouseDown != Rectangle.Empty &&
                !dragBoxFromMouseDown.Contains(e.X, e.Y))
            {

                // Proceed with the drag and drop, passing in the list item.                    
                DragDropEffects dropEffect = dgvPlayers.DoDragDrop(
                dgvPlayers.Rows[rowIndexFromMouseDown].DataBoundItem,
                DragDropEffects.Link);
            }
        } 
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_editKind != EditKind.None)
                btnEditCancel.PerformClick();

            Hide();
        }

        private void dgvPlayers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && _selectedPlayer != null)
                btnAddToMatch.PerformClick();
        }

        private void addDebugPlayers_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var player in PlayerList.Instance.Players.Take(3))
                {
                    _parentFrm.AddPlayerToMatch(player);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error");
            }
        }


    }
}