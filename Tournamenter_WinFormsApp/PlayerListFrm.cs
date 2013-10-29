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
        private Player _editedPlayer;
        private Player _selectedPlayer;

        public PlayerListFrm()
        {
            InitializeComponent();

            RefreshList();

            dgvPlayers.AutoGenerateColumns = true;

            PlayerList.Instance.PropertyChanged += Instance_PropertyChanged;
        }

        void Instance_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            dgvPlayers.DataSource = PlayerList.Instance.Players;
        }
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Player player = new Player()
            {
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                Nick = nickTextBox.Text,
                Info = infoTextBox.Text,
                Tag = tagTextBox.Text
            };

            PlayerList.Instance.Add(player);
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {

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

            SetPlayerEditData(_selectedPlayer);
        }


        private void SetPlayerEditData(Player player)
        {
            playerIdTextBox.Text = player.PlayerId.ToString();
            nameTextBox.Text = player.Name;     
            surnameTextBox.Text = player.Surname;    
            nickTextBox.Text = player.Nick; 
            infoTextBox.Text = player.Info;       
            tagTextBox.Text = player.Tag;      
        }
    }
}