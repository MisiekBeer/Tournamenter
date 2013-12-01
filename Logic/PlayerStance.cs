using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Player in- and pre-round stance
    /// </summary>
    [Serializable]
    public class PlayerStance : BaseLogicClass, IComparable<PlayerStance>
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
            set { playerId = value;
                    if (Player == null) 
                        Player = PlayerList.Instance[value];
                    OnPropertyChanged(PropNames.PlayerId); }
        }

        [NonSerialized]
        private Player player;
        public Player Player
        {
            get { return player; }
            private set { player = value;
                            if (PlayerId == 0)
                                PlayerId = value.PlayerId;
                          OnPropertyChanged(PropNames.Player); }
        }

        private int oponentId;
        public int OponentId
        {
            get { return oponentId; }
            set { oponentId = value;
                    if (Oponent == null)
                        Oponent = PlayerList.Instance[value];
                    OnPropertyChanged(PropNames.OponentId); }
        }

        [NonSerialized]
        private Player oponent;
        public Player Oponent
        {
            get { return oponent; }
            private set { oponent = value;
                            if (OponentId == 0)
                                OponentId = value.PlayerId;
                        OnPropertyChanged(PropNames.Oponent); }
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

        //private Round matchRound;
        //public Round MatchRound
        //{
        //    get { return matchRound; }
        //    set { matchRound = value; OnPropertyChanged(PropNames.Round); }
        //}

        private int tableNumber;
        public int TableNumber
        {
            get { return tableNumber; }
            set { tableNumber = value; OnPropertyChanged(PropNames.TableNumber); }
        }

        
        public static class PropNames
        {
            public const string PlayerId = "PlayerId";
            public const string OponentId = "OponentId";
            public const string Place = "Place";
            public const string Oponent = "Oponent";
            public const string SmallVP = "SmallVP";
            public const string BigVP = "BigVP";
            public const string TotalSmallVP = "TotalSmallVP";
            public const string TotalBigVP = "TotalBigVP";
            //public const string Round = "MatchRound";
            public const string Player = "Player";
            public const string TableNumber = "TableNumber";
        }

        public static readonly PlayerStance Empty = new PlayerStance() { Player = Player.Empty };
        public bool PointsEntered { get { return smallVP >= 0; } }
        #endregion


        #region ctor

        public PlayerStance()
        {
            SmallVP = -1;
        }

        /// <summary>
        /// Creates start stance
        /// </summary>
        /// <param name="player"></param>
        /// <param name="opponent"></param>
        public PlayerStance(Player player, Player opponent)
        {
            Player = player;
            Oponent = opponent;
        }

        /// <summary>
        /// Creates new stance for next round
        /// </summary>
        /// <param name="playerStance"></param>
        public PlayerStance(PlayerStance playerStance)
        {
            PlayerId = playerStance.PlayerId;
            TotalBigVP = playerStance.TotalBigVP + playerStance.BigVP;
            TotalSmallVP = playerStance.TotalSmallVP + playerStance.SmallVP;
            BigVP = 0;
            SmallVP = 0;
        }
        #endregion

        public override string ToString()
        {
            return string.Format("Player: {0} place from {1} round", Player.ToString());
        }

        public int CompareTo(PlayerStance other)
        {
            int result = bigVP.CompareTo(other.bigVP);
            return result != 0 ? result : smallVP.CompareTo(other.smallVP);
        }
    }
}
