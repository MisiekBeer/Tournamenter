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
        private Player _player;
        private PlayerStance _playerStance;

        public PlayerPositionCtrl()
        {   
            InitializeComponent();
        }

        public PlayerPositionCtrl(Player player)
        {
            InitializeComponent();

            SetShowPoints(false);

            _player = player;

            tbImie.Text = _player.Name;
            tbKsywa.Text = _player.Nick;
            tbNazwisko.Text = _player.Surname;
        }

        private void SetShowPoints(bool _showPoints)
        {
            SuspendLayout();

            groupPunkty.Visible = false;
            this.Height = Height - groupPunkty.Height;
            groupPunkty.Height = 1;

            ResumeLayout();
        }
    }
}
