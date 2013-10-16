using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Match : BaseLogicClass
    {
        #region properties
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
        public List<Player> Players
        {
            get { return players; }
            private set { players = value; OnPropertyChanged(PropNames.Players); }
        }


        private List<Round> rounds;
        public List<Round> Rounds
        {
            get { return rounds; }
            private set { rounds = value; OnPropertyChanged(PropNames.Rounds); }
        }

        public static class PropNames
        {
            public const string Name = "Name";
            public const string Settings = "Settings";
            public const string Players = "Players";
            public const string Rounds = "Rounds";
            public const string MatchDate = "MatchDate";
        }
        #endregion

        public Match()
        {
            Name = "New Match";
            MatchDate = DateTime.Today.Date;
            Players = new List<Player>();
            Rounds = new List<Round>();
            Settings = new MatchSettings();
        } 

        public override string ToString()
        {
            return string.Format("Match: {0} - {1}", Name, MatchDate);
        }
    }
}
