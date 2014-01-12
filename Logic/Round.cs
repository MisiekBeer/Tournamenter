﻿using Logic.Extensions;
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
    public class PlayerPair
    {
        public PlayerStance Player1 { get; private set; }

        public PlayerStance Player2 { get; private set; }

        public PlayerPair(PlayerStance player1, PlayerStance player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
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

        private List<PlayerPair> playerPairs;
        public List<PlayerPair> PlayerPairs
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
            PlayerPairs = new List<PlayerPair>();
            Number = 1;
        }

        public Round(List<PlayerPair> pairs) : this()
        {
            PlayerPairs.AddRange(pairs);

            foreach (var pair in pairs)
            {
                PlayerPlaces.Add(pair.Player1);
                PlayerPlaces.Add(pair.Player2);
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
                playerPairs.Add(new PlayerPair(player1_Stance, player2_Stance));
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
                playerPairs.Add(new PlayerPair(player1_Stance, player2_Stance));
            }
            Status = RoundStatus.RoundStarted;
            Contract.Ensures(players.Count == 0, "Player generation list is not emptied");
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
            int table = 1;

            var newPairs = new List<PlayerPair>(places.Count/2 + 1);
            while ((places.Count / 2) > 0)
            {//TODO: Add tables repeat check
                newPairs.Add(new PlayerPair(
                    new PlayerStance(places[0]) { Place = ++place, TableNumber = table, OponentId = places[1].PlayerId },
                    new PlayerStance(places[1]) { Place = ++place, TableNumber = table, OponentId = places[0].PlayerId }
                    ));
                places.RemoveRange(0, 2);
            }
            if (places.Count == 1)
            {
                newPairs.Add(new PlayerPair(
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
            int drawPoints = Match.Settings.PointRanges[0].WinnerPoints;

            foreach (var pair in PlayerPairs)
            {
                PlayerStance stance1 = pair.Player1;
                PlayerStance stance2 = pair.Player2;

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
                else {
                    stance1.BigVP += Match.Settings.GetLooserPoints(diff);
                    stance2.BigVP += Match.Settings.GetWinnerPoints(diff);
                }              
            }
        }
    }
}
