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
    public partial class PlayerListFrm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public enum EditKind
        {
            None,
            Add,
            Change,
            Remove
        }

        private Player _selectedPlayer;
        private EditKind _editKind = EditKind.None;

        public PlayerListFrm()
        {
            InitializeComponent();
            dgvPlayers.AutoGenerateColumns = true;
            BlockEditors(true);

            RefreshList();

            PlayerList.Instance.PropertyChanged += Instance_PropertyChanged;
        }

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
                MessageBox.Show("Player name empty!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(surnameTextBox.Text))
            {
                MessageBox.Show("Player surname empty!");
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
        }

        private void checkSet_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (checkSet.CheckedButton == checkBtnAddPlayer)
            {
                _editKind = EditKind.Add;
                ClearEditors();
                BlockEditors(false);
                return;
            }
            if (checkSet.CheckedButton == checkButtonEditPlayer)
            {
                _editKind = EditKind.Change;
                BlockEditors(false);
                return;
            }
            if (checkSet.CheckedButton == checkButtonRemovePlayer)
            {
                _editKind = EditKind.Remove;
                BlockEditors(true);
                return;
            }
            _editKind = EditKind.None;
        }

    }
}