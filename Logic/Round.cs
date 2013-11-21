using Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Logic
{
    public enum RoundStatus
    {
        NotSet,
        CalculatingPairings,
        RoundStarted,
        RoundClosed,
    }

    [Serializable]
    public class Round : BaseLogicClass
    {
        #region properties

        private RoundStatus status;
        public RoundStatus Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged(PropNames.Status); }
        }

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

        private List<Tuple<PlayerStance, PlayerStance>> playerPairs;
        public List<Tuple<PlayerStance, PlayerStance>> PlayerPairs
        {
            get { return playerPairs; }
            private set { playerPairs = value; }
        }

        public static class PropNames
        {
            public const string Status = "Status";
            public const string Number = "Number";
            public const string PlayerPlaces = "PlayerPlaces";
            public const string PlayerPairs = "PlayerPairs";
        }

        public bool AllPointsEntered
        {
            get { return playerPlaces.All(n => n.PointsEntered); }
        }

        public Match Match { get; set; }
        #endregion

        #region ctor
        public Round()
        {
            PlayerPlaces = new List<PlayerStance>();
            PlayerPairs = new List<Tuple<PlayerStance, PlayerStance>>();
            Number = 1;
        }

        public Round(List<Tuple<PlayerStance, PlayerStance>> pairs) : this()
        {
            PlayerPairs.AddRange(pairs);
        } 
        #endregion

        #region methods
        public override string ToString()
        {
            return string.Format("Round number: {0}", Number);
        }

        internal void GenerateStartPairs(List<Player> players)
        {
            Status = RoundStatus.CalculatingPairings;

            players = new List<Player>(players);
            players.Randomize();

            int place = 1;
            int tableNumber = 1;
            Player player1 = null;
            PlayerStance player1_Stance = null;
            Player player2 = null;
            PlayerStance player2_Stance = null;

            while (players.Count / 2 >= 1)
            {
                player1 = players.First();
                players.RemoveAt(0);
                player2 = players.First();
                players.RemoveAt(0);

                player1_Stance = new PlayerStance(player1, player2) { Place = place, TableNumber = tableNumber};
                place++;
                player2_Stance = new PlayerStance(player2, player1) { Place = place, TableNumber = tableNumber};
                place++;

                tableNumber++;
                playerPlaces.Add(player1_Stance);
                playerPlaces.Add(player2_Stance);
                playerPairs.Add(new Tuple<PlayerStance, PlayerStance>(player1_Stance, player2_Stance));
            }

            if (players.Count == 1)
            {
                player1 = players.First();
                players.RemoveAt(0);
                player2 = Player.Empty;

                player1_Stance = new PlayerStance(player1, player2) { Place = place, TableNumber = tableNumber };
                place++;
                player2_Stance = new PlayerStance(player2, player1) { Place = place, TableNumber = tableNumber };
                place++;

                tableNumber++;
                playerPlaces.Add(player1_Stance);
                playerPlaces.Add(player2_Stance);
                playerPairs.Add(new Tuple<PlayerStance, PlayerStance>(player1_Stance, player2_Stance));
            }
            Status = RoundStatus.RoundStarted;
            Contract.Ensures(players.Count == 0, "Player generation list is not emptied");
        }

        private List<Tuple<PlayerStance, PlayerStance>> GenerateRankingPairs(Round previousRound)
        {
            //create pairs from compairing results

            //check if players already played with opponent and swap to next oponent if necessery
            return null;
        }

        internal PlayerStance GetOpponent(PlayerStance playerStance)
        {
            Tuple<PlayerStance, PlayerStance> pair = 
                playerPairs.First(n => n.Item1 == playerStance || n.Item2 == playerStance);

            return pair.Item1 == playerStance ? pair.Item2 : pair.Item1; 
        }

        #endregion
        /// <summary>
        /// Closes round and calculates next with proper values
        /// </summary>
        /// <returns>new Round</returns>
        internal Round CloseAndGenerateNext()
        {
            var pairs = GenerateRankingPairs(this);
            return new Round(pairs) { Number = this.Number + 1, Match = this.Match};
        }
    }
}
