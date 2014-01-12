using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace Tournamenter_WinFormsApp
{
    public partial class VsCtrl : UserControl
    {
        public VsCtrl()
        {
            InitializeComponent();
        }

        public VsCtrl(PlayerPositionCtrl player1, PlayerPositionCtrl player2)
        {
            InitializeComponent();

            Contract.Assert(player1 != null && player2 != null, "Player 1 and 2 cannot be null");

            SuspendLayout();

            vsGroup.Panel.Width = player1.Width;
            vsGroup.Panel.Height = player1.Height * 2 + 3;
            vsGroup.Panel.Controls.Add(player1);
            player2.Location = new Point(0, player1.Height + 4);
            vsGroup.Panel.Controls.Add(player2);

            vsGroup.ValuesSecondary.Heading = string.Format("Table: {0}", player1.Stance.TableNumber.ToString());
            vsGroup.ValuesPrimary.Heading = string.Format("{1}  VS  {0}", player1.Stance.Player.Nick, player2.Stance.Player.Nick);

            ResumeLayout();
        }

    }
}
