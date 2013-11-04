using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    [Serializable]
    public class Round : BaseLogicClass
    {
        #region properties
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; OnPropertyChanged(PropNames.Number); }
        }
        
        private List<PlayerStance> playerPlaces;
        public List<PlayerStance> PlayerPlaces
        {
            get { return playerPlaces; }
            private set { playerPlaces = value; OnPropertyChanged(PropNames.PlayerPlaces); }
        }

        public static class PropNames
        {
            public const string Number = "Number";
            public const string PlayerPlaces = "PlayerPlaces";
        } 
        #endregion

        public Round()
        {
            PlayerPlaces = new List<PlayerStance>();
            Number = 1;
        }
        public override string ToString()
        {
            return string.Format("Round number: {0}", Number);
        }
    }
}
