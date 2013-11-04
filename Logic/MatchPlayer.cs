using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MatchPlayer : Player
    {
        #region props
        private int totalSmallVP;
        public int TotalSmallVP
        {
            get { return totalSmallVP; }
            set { totalSmallVP = value; OnPropertyChanged(PropNames.TotalSmallVP); }
        }


        private int totalBigVP;
        public int TotalBigVP
        {
            get { return totalBigVP; }
            set { totalBigVP = value; OnPropertyChanged(PropNames.TotalBigVP); }
        } 
        #endregion

        public MatchPlayer() : base()
        {

        }
    }
}
