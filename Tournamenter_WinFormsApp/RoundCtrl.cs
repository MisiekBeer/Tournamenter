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

namespace Tournamenter_WinFormsApp
{
    public partial class RoundCtrl : UserControl
    {
        public RoundCtrl()
        {
            InitializeComponent();
        }

        public void AddControl(Control ctrl)
        {
            tableLayout.SuspendLayout();


            tableLayout.Controls.Add(ctrl);

            tableLayout.ResumeLayout();
        }
    }
}
