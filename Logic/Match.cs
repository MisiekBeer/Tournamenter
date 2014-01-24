using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logic
{
    public enum MatchStatus
    {
        NotSet,
        PlayersEnlisting,
        RoundStarted,
        RoundTimeEnded,
        RoundClosed,
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
            set { status = value; OnPropertyChanged(PropNames.Status);
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
            set { matchDate = value; OnPropertyChanged(PropNames.MatchDate); }
        }

        private MatchSettings settings;
        public MatchSettings Settings
        {
            get { return settings; }
            set { settings = value; OnPropertyChanged(PropNames.Settings); }
        }

        private List<Player> players;
        /// <summary>
        /// All match players
        /// </summary>
        public List<Player> Players
        {
            get { return players; }
            set { players = value; OnPropertyChanged(PropNames.Players); }
        }

        private List<Round> rounds;
        /// <summary>
        /// Current match rounds - starts with count 1(initial round)
        /// </summary>
        public List<Round> Rounds
        {
            get { return rounds; }
            set { rounds = value; OnPropertyChanged(PropNames.Rounds); }
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

            string result = string.Empty;
            match.AutoSave(out result);
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
            Status = MatchStatus.RoundClosed;

            Round newRound = (Rounds.Count + 1 < settings.RoundCount) ? 
                ActiveRound.CloseAndGenerateNext() : ActiveRound.CloseMatchEndRound();
            Rounds.Add(newRound);

            Status = settings.RoundCount > Rounds.Count ?
                MatchStatus.RoundStarted : MatchStatus.MatchEnded;

            if (RoundAdded != null)
                RoundAdded(this, newRound);
            return true;        
        }

        internal bool CheckIfPlayerWasOpponent(PlayerStance player, int opponentId)
        {
            return rounds.Any(n => n.GetCurrentOpponent(player) == opponentId);
        }

        internal IEnumerable<int> GetPlayerTables(PlayerStance player)
        {
            return rounds.Select(n=>n.GetPlayerTable(player));
        }

        #region save Match
        public bool AutoSave(out string result)
        {
            string resultInner = string.Empty;
            bool success = Save(string.Format(
                "match{0:yyyyMMdd_HHmmssff}SaveRound{1}.xml", MatchDate, Rounds.Count), out resultInner);

            result = resultInner;
            return success;
        }

        public bool Save(string filePath, out string result)
        {
            TextWriter writer = null;
            XmlSerializer serializer = null;
            try
            {
                writer = new StreamWriter(filePath);

                serializer = new XmlSerializer(typeof(Match));
                serializer.Serialize(writer, this);
            }
            catch (Exception e)
            {
                result = e.ToString();
                return false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Dispose();
                    writer = null;
                }
            }
            result = "OK";
            return true;
        }

        public static Match Load(string filePath, out string result)
        {
            TextReader reader = null;
            XmlSerializer serializer = null;
            Match match = null;

            try
            {
                reader = new StreamReader(filePath);

                serializer = new XmlSerializer(typeof(Match));
                match = serializer.Deserialize(reader) as Match;
            }
            catch (Exception e)
            {
                result = e.ToString();
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();
                    reader = null;
                }
            }

            foreach (Round round in match.Rounds)
            {
                round.Match = match;
            }

            result = "OK";
            return match;
        }
        #endregion
        #endregion
    }
}
