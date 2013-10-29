using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    [Serializable]
    public class Player : BaseLogicClass
    {
        #region properties
        private int playerId;
        public int PlayerId
        {
            get { return playerId; }
            set { playerId = value; OnPropertyChanged(PropNames.PlayerId); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(PropNames.Name); }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged(PropNames.Surname); }
        }

        private string nick;
        public string Nick
        {
            get { return nick; }
            set { nick = value; OnPropertyChanged(PropNames.Nick); }
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

        private string tag;
        public string Tag
        {
            get { return tag; }
            set { tag = value; OnPropertyChanged(PropNames.Tag); }
        }


        private string info;
        public string Info
        {
            get { return info; }
            set { info = value; OnPropertyChanged(PropNames.Info); }
        }


        public static class PropNames
        {
            public const string PlayerId = "PlayerId";
            public const string Name = "Name";
            public const string Surname = "Surname";
            public const string Nick = "Nick";
            public const string TotalSmallVP = "TotalSmallVP";
            public const string TotalBigVP = "TotalBigVP";
            public const string Tag = "Tag";
            public const string Info = "Info";
        } 
        #endregion

        public Player()
        {
            
        }

        public override string ToString()
        {
            return string.Format("{0} {1} '{2}'", surname, name, nick);
        }
    }
}
