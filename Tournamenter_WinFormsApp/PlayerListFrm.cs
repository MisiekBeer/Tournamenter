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
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            SetPlayerDataFromEditors(player);

            PlayerList.Instance.Add(player);
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            SetPlayerDataFromEditors(_selectedPlayer);
            PlayerList.Instance.SavePlayerList();
        }


        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            PlayerList.Instance.Remove(_selectedPlayer);
            _selectedPlayer = null;
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

        private void SetEditKind(EditKind editKind)
        {
            switch (editKind)
            {
                case EditKind.None:
                    btnAddPlayer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
                    btnEditPlayer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
                    btnDeletePlayer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
                    break;
                case EditKind.Add:
                    break;
                case EditKind.Change:
                    break;
                case EditKind.Remove:
                    break;
            }
            _editKind = editKind;
        }

        private void btnEditOK_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {

        }

        private void checkBtnAddPlayer_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}