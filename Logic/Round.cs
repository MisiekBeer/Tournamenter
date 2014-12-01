using Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Logic
{
    public enum RoundStatus
    {
        NotSet,
        CalculatingPairings,
        RoundStarted,
        RoundClosed,
        MatchResult
    }

    [Serializable]
    public class PlayerPair
    {
        public PlayerStance Player1 { get; set; }

        public PlayerStance Player2 { get; set; }

        public PlayerPair()
        {
        }

        public PlayerPair(PlayerStance player1, PlayerStance player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public bool IsBay { get { return Player1 == PlayerStance.Empty || Player2 == PlayerStance.Empty; } }

        public override string ToString()
        {
            return string.Concat(Player1.ToString(), " vs ", Player2.ToString());
        }
    }

    [Serializable]
    public class Round : BaseLogicClass
    {
        #region Properties

        #region Serializable

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

        private List<PlayerPair> playerPairs;

        public List<PlayerPair> PlayerPairs
        {
            get { return playerPairs; }
            set { playerPairs = value; }
        }

        #endregion Serializable

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

        [XmlIgnore]
        public Match Match { get; set; }

        #endregion Properties

        #region ctor

        /// <summary>
        /// Empty round
        /// </summary>
        public Round()
        {
            PlayerPlaces = new List<PlayerStance>();
            PlayerPairs = new List<PlayerPair>();
            Number = 1;
        }

        /// <summary>
        /// Match round with points
        /// </summary>
        /// <param name="pairs"></param>
        public Round(List<PlayerPair> pairs)
            : this()
        {
            PlayerPairs.AddRange(pairs);

            foreach (var pair in pairs)
            {
                PlayerPlaces.Add(pair.Player1);
                PlayerPlaces.Add(pair.Player2);
            }
        }

        /// <summary>
        /// Final Player List
        /// </summary>
        /// <param name="playerPlaces"></param>
        public Round(List<PlayerStance> finalPlaces)
            : this()
        {
            foreach (PlayerStance place in finalPlaces)
            {
                PlayerPlaces.Add(new PlayerStance(place));
            }
            PlayerPlaces.Remove(PlayerStance.Empty); //remove bay player
            PlayerPlaces.Sort();

            foreach (PlayerStance place in PlayerPlaces)
            {
                place.Place = playerPlaces.IndexOf(place) + 1;
            }
        }

        #endregion ctor

        #region methods

        public override string ToString()
        {
            return string.Format("Round number: {0}", Number);
        }

        internal void GenerateStartPairs(List<Player> players)
        {
            Status = RoundStatus.CalculatingPairings;

            players = new List<Player>(players.Randomize());

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

                player1_Stance = new PlayerStance(player1, player2)
                {
                    Place = place,
                    TableNumber = tableNumber
                };
                place++;
                player2_Stance = new PlayerStance(player2, player1)
                {
                    Place = place,
                    TableNumber = tableNumber
                };
                place++;

                tableNumber++;
                playerPlaces.Add(player1_Stance);
                playerPlaces.Add(player2_Stance);
                playerPairs.Add(new PlayerPair(player1_Stance, player2_Stance));
            }

            if (players.Count == 1)
            {
                player1 = players.First();
                players.RemoveAt(0);
                //BAY playa
                player1_Stance = new PlayerStance(player1, Player.Empty)
                {
                    Place = place,
                    TableNumber = -1,
                    BigVP = 10,
                    IsBay = true
                };
                place++;
                player2_Stance = PlayerStance.Empty;
                place++;

                tableNumber++;
                playerPlaces.Add(player1_Stance);
                playerPlaces.Add(player2_Stance);
                playerPairs.Add(new PlayerPair(player1_Stance, player2_Stance));
            }
            Status = RoundStatus.RoundStarted;

            Speaker.Instance.StartRoundTimerSpeaker(Match.Settings.RoundTime);
        }

        private List<PlayerPair> GenerateRankingPairs()
        {
            //create pairs from compairing results
            List<PlayerStance> places = new List<PlayerStance>(PlayerPlaces);
            places.Remove(PlayerStance.Empty); //remove bay player
            places.Sort();
            places.Reverse();

            SwapRepeatedOpponents(places);
            int place = 0;
            HashSet<int> tables = new HashSet<int>(Enumerable.Range(1, Match.Settings.TablesCount).Randomize());

            var newPairs = new List<PlayerPair>((places.Count / 2) + (places.Count % 2));
            PlayerStance first = null;
            PlayerStance second = null;

            while ((places.Count / 2) > 0)
            {
                first = places[0];
                second = places[1];

                int tableNr = tables.FirstOrDefault(n =>
                    Match.GetPlayerTables(first).Union(Match.GetPlayerTables(second)).Intersect(tables).Count() == 0);

                if (tableNr == 0)
                    tableNr = tables.First();
                tables.Remove(tableNr);

                newPairs.Add(new PlayerPair(
                    new PlayerStance(first)
                    {
                        Place = ++place,
                        TableNumber = tableNr,
                        OponentId = second.PlayerId
                    },
                    new PlayerStance(second)
                    {
                        Place = ++place,
                        TableNumber = tableNr,
                        OponentId = first.PlayerId
                    })
                            );
                places.RemoveRange(0, 2);
            }
            if (places.Count == 1)
            {
                newPairs.Add(new PlayerPair(
                    new PlayerStance(places[0])
                    {
                        Place = ++place,
                        TableNumber = -1,
                        OponentId = EmptyPlayer.EmptyPlayerId,
                        IsBay = true,
                        BigVP = Match.Settings.PointsForBay
                    },
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
                else
                {
                    tmpStance = plStance.Next; if (plStance.Next == players.Last) break;
                    tmpStance = plStance.Next;
                    while (Match.CheckIfPlayerWasOpponent(plStance.Value, tmpStance.Value.PlayerId))
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
            PlayerPair pair =
                playerPairs.First(n => n.Player1.PlayerId == id || n.Player2.PlayerId == id);

            return pair.Player1.PlayerId == id ? pair.Player2.PlayerId : pair.Player1.PlayerId;
        }

        internal int GetPlayerTable(PlayerStance playerStance)
        {
            int id = playerStance.PlayerId;
            PlayerPair pair =
                playerPairs.First(n => n.Player1.PlayerId == id || n.Player2.PlayerId == id);

            return pair.Player1.TableNumber;
        }

        #endregion methods

        /// <summary>
        /// Closes round and calculates next with proper values
        /// </summary>
        /// <returns>new Round</returns>
        internal Round CloseAndGenerateNext()
        {
            try
            {
                UpdateBigPoints();
                var pairs = GenerateRankingPairs();

                return new Round(pairs) { Number = this.Number + 1, Match = this.Match };
            }
            finally
            {
                Speaker.Instance.StartRoundTimerSpeaker(Match.Settings.RoundTime);
            }
        }

        private void UpdateBigPoints()
        {
            int drawPoints = Match.Settings.PointRanges[0].WinPts;

            foreach (var pair in PlayerPairs)
            {
                PlayerStance stance1 = pair.Player1;
                PlayerStance stance2 = pair.Player2;

                if (pair.IsBay)
                {
                    if (stance1 != PlayerStance.Empty)
                    {
                        stance1.IsBay = true;
                        stance1.SmallVP = 0;
                        stance1.BigVP = Match.Settings.PointsForBay;
                    }
                    if (stance2 != PlayerStance.Empty)
                    {
                        stance2.IsBay = true;
                        stance2.SmallVP = 0;
                        stance2.BigVP = Match.Settings.PointsForBay;
                    }
                    continue;
                }

                int diff = stance1.SmallVP - stance2.SmallVP;
                if (diff == 0)
                {
                    stance1.BigVP += drawPoints;
                    stance2.BigVP += drawPoints;
                    continue;
                }

                if (stance1.SmallVP > stance2.SmallVP)
                {
                    stance1.BigVP += Match.Settings.GetWinnerPoints(diff);
                    stance2.BigVP += Match.Settings.GetLooserPoints(diff);
                }
                else
                {
                    stance1.BigVP += Match.Settings.GetLooserPoints(diff);
                    stance2.BigVP += Match.Settings.GetWinnerPoints(diff);
                }
            }
        }

        /// <summary>
        /// Generates final result for display as round
        /// </summary>
        /// <returns></returns>
        internal Round CloseMatchEndRound()
        {
            UpdateBigPoints();

            List<PlayerStance> finalPlaces = new List<PlayerStance>(PlayerPlaces);
            foreach (PlayerPair pair in PlayerPairs)
            {
                finalPlaces.Add(pair.Player1);
                finalPlaces.Add(pair.Player2);
            }

            Round lastRound = new Round(this.PlayerPlaces)
            {
                Number = this.Number + 1,
                Match = this.Match,
                Status = RoundStatus.MatchResult
            };

            return lastRound;
        }
    }
}