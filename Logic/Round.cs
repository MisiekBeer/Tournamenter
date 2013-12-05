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

            foreach (var pair in pairs)
            {
                PlayerPlaces.Add(pair.Item1);
                PlayerPlaces.Add(pair.Item2);
            }
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

            while ((players.Count / 2) > 0)
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

                player1_Stance = new PlayerStance(player1, Player.Empty) { Place = place, TableNumber = tableNumber };
                place++;
                player2_Stance = new PlayerStance(Player.Empty, player1) { Place = place, TableNumber = tableNumber };
                place++;

                tableNumber++;
                playerPlaces.Add(player1_Stance);
                playerPlaces.Add(player2_Stance);
                playerPairs.Add(new Tuple<PlayerStance, PlayerStance>(player1_Stance, player2_Stance));
            }
            Status = RoundStatus.RoundStarted;
            Contract.Ensures(players.Count == 0, "Player generation list is not emptied");
        }

        private List<Tuple<PlayerStance, PlayerStance>> GenerateRankingPairs()
        {
            //create pairs from compairing results
            List<PlayerStance> places = new List<PlayerStance>(PlayerPlaces);
            places.Remove(PlayerStance.Empty); //remove bay player
            places.Sort();
            places.Reverse();

            SwapRepeatedOpponents(places);
            int place = 0;
            int table = 1;

            var newPairs = new List<Tuple<PlayerStance, PlayerStance>>(places.Count/2 + 1);
            while ((places.Count / 2) > 0)
            {//TODO: Add table verification
                newPairs.Add(new Tuple<PlayerStance, PlayerStance>(
                    new PlayerStance(places[0]) { Place = ++place, TableNumber = table, OponentId = places[1].PlayerId },
                    new PlayerStance(places[1]) { Place = ++place, TableNumber = table, OponentId = places[0].PlayerId }
                    ));
                places.RemoveRange(0, 2);
            }
            if (places.Count == 1)
            {
                newPairs.Add(new Tuple<PlayerStance, PlayerStance>(
                    new PlayerStance(places[0]) { Place = ++place, TableNumber = -1, OponentId = PlayerStance.Empty.PlayerId }, 
                    PlayerStance.Empty));
            }
            return newPairs;
        }

        /// <summary>
        /// Organizes players list in "pairs" of new opponents
        /// </summary>
        /// <param name="playersList">organized list</param>
        private void SwapRepeatedOpponents(List<PlayerStance> playersList)
        {
            LinkedList<PlayerStance> players = new LinkedList<PlayerStance>(playersList);

            LinkedListNode<PlayerStance> plStance = players.First;
            LinkedListNode<PlayerStance> tmpStance = null;
            while (plStance != null && plStance != players.Last)
            {
                if (!Match.CheckIfPlayerWasOpponent(plStance.Value, plStance.Next.Value.PlayerId))
                {
                    if (plStance.Next == players.Last) break;
                    plStance = plStance.Next;
                    if (plStance.Next == players.Last) break;
                    plStance = plStance.Next;
                }
                else {
                    tmpStance = plStance.Next; if (plStance.Next == players.Last) break;
                    tmpStance = plStance.Next;
                    while(Match.CheckIfPlayerWasOpponent(plStance.Value, tmpStance.Value.PlayerId))
                    {
                        if (tmpStance == players.Last)
                            break;
                        tmpStance = tmpStance.Next; 
                        if (tmpStance == players.Last) 
                            break;
                    }
                    players.Remove(tmpStance);
                    players.AddAfter(plStance, tmpStance);
                    if (tmpStance == players.Last)
                        break;
                    plStance = tmpStance.Next;
                }
            }
            playersList.Clear();
            playersList.AddRange(players);
        }

        internal int GetCurrentOpponent(PlayerStance playerStance)
        {
            int id = playerStance.PlayerId;
            Tuple<PlayerStance, PlayerStance> pair = 
                playerPairs.First(n => n.Item1.PlayerId == id || n.Item2.PlayerId == id);

            return pair.Item1.PlayerId == id ? pair.Item2.PlayerId : pair.Item1.PlayerId; 
        }

        internal int GetPlayerTable(PlayerStance playerStance)
        { 
            int id = playerStance.PlayerId;
            Tuple<PlayerStance, PlayerStance> pair =
                playerPairs.First(n => n.Item1.PlayerId == id || n.Item2.PlayerId == id);
            
            return pair.Item1.TableNumber; 
        }

        #endregion
        /// <summary>
        /// Closes round and calculates next with proper values
        /// </summary>
        /// <returns>new Round</returns>
        internal Round CloseAndGenerateNext()
        {
            UpdateBigPoints();
            var pairs = GenerateRankingPairs();
            return new Round(pairs) { Number = this.Number + 1, Match = this.Match};
        }

        private void UpdateBigPoints()
        {
            int drawPoints = Match.Settings.PointsForDraw;

            foreach (var pair in PlayerPairs)
            {//TODO: Dodać wczytywanie z tabeli zakresów
                PlayerStance stance1 = pair.Item1;
                PlayerStance stance2 = pair.Item2;

                int diff = stance1.SmallVP - stance2.SmallVP;
                if (diff == 0)
                {
                    stance1.BigVP += drawPoints;
                    stance2.BigVP += drawPoints;
                }
                else
                {
                    stance1.BigVP += drawPoints + diff;
                    stance2.BigVP += drawPoints - diff;
                }              
            }
        }
    }
}
