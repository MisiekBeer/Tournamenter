using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PlayerStance : BaseLogicClass
    {
        #region properties
        private int place;
        public int Place
        {
            get { return place; }
            set { place = value; OnPropertyChanged(PropNames.Place); }
        }

        private int playerId;
        public int PlayerId
        {
            get { return playerId; }
            set { playerId = value; OnPropertyChanged(PropNames.PlayerId); }
        }

        private Player player;
        public Player Player
        {
            get { return player; }
            set { player = value; OnPropertyChanged(PropNames.Player); }
        }

        private Player oponent;
        public Player Oponent
        {
            get { return oponent; }
            set { oponent = value; OnPropertyChanged(PropNames.Oponent); }
        }

        private int smallVP;
        public int SmallVP
        {
            get { return smallVP; }
            set { smallVP = value; OnPropertyChanged(PropNames.SmallVP); }
        }

        private int bigVP;
        public int BigVP
        {
            get { return bigVP; }
            set { bigVP = value; OnPropertyChanged(PropNames.BigVP); }
        }

        private Round matchRound;
        public Round MatchRound
        {
            get { return matchRound; }
            set { matchRound = value; OnPropertyChanged(PropNames.Round); }
        }

        private int tableNumber;
        public int TableNumber
        {
            get { return tableNumber; }
            set { tableNumber = value; OnPropertyChanged(PropNames.TableNumber); }
        }

        
        public static class PropNames
        {
            public const string PlayerId = "PlayerId";
            public const string Place = "Place";
            public const string Oponent = "Oponent";
            public const string SmallVP = "SmallVP";
            public const string BigVP = "BigVP";
            public const string Round = "MatchRound";
            public const string Player = "Player";
            public const string TableNumber = "TableNumber";
        } 
        #endregion

        public override string ToString()
        {
            return string.Format("Player: {0} place from {1} round", Player.ToString(), MatchRound.Number);
        }
    }
}
