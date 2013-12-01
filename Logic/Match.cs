using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public enum MatchStatus
    {
        NotSet,
        PlayersEnlisting,
        RoundStarted,
        RoundEnded,
        MatchEnded
    }

    [Serializable]
    public class Match : BaseLogicClass
    {
        #region events
        public event EventHandler<Player> PlayerAdded;
        public event EventHandler<MatchStatus> MatchStatusChanged;
        public event EventHandler<Round> RoundAdded;
        #endregion

        #region properties

        private MatchStatus status;
        public MatchStatus Status
        {
            get { return status; }
            private set { status = value; OnPropertyChanged(PropNames.Status);
                if (MatchStatusChanged != null) MatchStatusChanged(this, value);
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(PropNames.Name); }
        }

        private DateTime matchDate;
        public DateTime MatchDate
        {
            get { return matchDate; }
            private set { matchDate = value; OnPropertyChanged(PropNames.MatchDate); }
        }

        private MatchSettings settings;
        public MatchSettings Settings
        {
            get { return settings; }
            private set { settings = value; OnPropertyChanged(PropNames.Settings); }
        }

        private List<Player> players;
        /// <summary>
        /// All match players
        /// </summary>
        public List<Player> Players
        {
            get { return players; }
            private set { players = value; OnPropertyChanged(PropNames.Players); }
        }

        private List<Round> rounds;
        /// <summary>
        /// Current match rounds - starts with count 1(initial round)
        /// </summary>
        public List<Round> Rounds
        {
            get { return rounds; }
            private set { rounds = value; OnPropertyChanged(PropNames.Rounds); }
        }

        public static class PropNames
        {
            public const string Status = "Status";
            public const string Name = "Name";
            public const string Settings = "Settings";
            public const string Players = "Players";
            public const string Rounds = "Rounds";
            public const string MatchDate = "MatchDate";
        }

        public bool CanCloseSafe {
            get
            {
                return  Status == MatchStatus.NotSet ||
                        Status == MatchStatus.MatchEnded ||
                        (Status == MatchStatus.PlayersEnlisting && players.Count == 0);
            } 
        }

        public int PlayerCount { get { return players.Count; } }

        public int ActiveRoundCount { get { return rounds.Count - 1; } }

        public Round ActiveRound { get { return rounds.Last(); } }

        #endregion

        #region ctor
        public Match()
        {
            Name = "New Match";
            Status = MatchStatus.PlayersEnlisting;
            MatchDate = DateTime.Today.Date;
            Players = new List<Player>();
            Rounds = new List<Round>();
            Settings = new MatchSettings();
        }

        public static Match CreateNewMatch(MatchSettings settings)
        {
            Match match = new Match() { Status = MatchStatus.PlayersEnlisting};
            match.Save();
            return match;
        }

        public static Match CreateNewMatch()
        {
            MatchSettings defaultSettings = new MatchSettings();
            return CreateNewMatch(defaultSettings);
        } 
        #endregion

        #region methods
        public override string ToString()
        {
            return string.Format("Match: {0} - {1}", Name, MatchDate);
        }
        /// <summary>
        /// Adds player to match
        /// </summary>
        /// <param name="player"></param>
        /// <returns>false if player already exists</returns>
        public bool AddPlayer(Player player)
        {
            if (Status != MatchStatus.PlayersEnlisting || players.Any(n => n.PlayerId == player.PlayerId))
                return false;

            players.Add(player);

            if (PlayerAdded != null)
                PlayerAdded(this, player);
            return true;
        }

        public void Save()
        {
            //throw new NotImplementedException();
        }

        public Round StartMatch()
        {
            if (players.Count < 3 || Status != MatchStatus.PlayersEnlisting)
                return null;

            Round round = new Round() { Match = this };
            round.GenerateStartPairs(players);
            rounds.Add(round);

            Status = MatchStatus.RoundStarted;
            return round;
        }

        public bool CloseRoundAndGenerateNext()
        {
            if (!ActiveRound.AllPointsEntered)
                return false;
            Status = MatchStatus.RoundEnded;

            Round newRound = ActiveRound.CloseAndGenerateNext();
            Rounds.Add(newRound);

            if (settings.RoundCount >= rounds.Count)
            {
                Status = MatchStatus.RoundStarted;
            }
            else
            {
                Status = MatchStatus.MatchEnded;
            }

            if (RoundAdded != null)
                RoundAdded(this, newRound);
            return true;        
        }

        internal bool CheckIfPlayerWasOpponent(PlayerStance player, int opponentId)
        {
            return rounds.Any(n => n.GetCurrentOpponent(player) == opponentId);
        }
        #endregion
    }
}
