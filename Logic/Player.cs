﻿using System;
using System.Xml.Serialization;

namespace Logic
{
    /// <summary>
    /// Player data
    /// </summary>
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
            public const string Tag = "Tag";
            public const string Info = "Info";
        }

        public static readonly EmptyPlayer Empty;

        #endregion properties

        #region ctor

        static Player()
        {
            Empty = EmptyPlayer.Instance;
        }

        public Player()
        {
        }

        #endregion ctor

        public bool Equals(Player player)
        {
            if (player == null)
                return false;

            return (player.playerId == this.playerId);
        }

        public override bool Equals(object obj)
        {
            Player player = obj as Player;
            if (player == null)
                return false;

            return (player.playerId == this.playerId);
        }

        public override int GetHashCode()
        {
            return this.playerId;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} '{2}'", surname, name, nick);
        }
    }

    [Serializable]
    public sealed class EmptyPlayer : Player
    {
        [NonSerialized]
        public const int EmptyPlayerId = -1;

        [NonSerialized]
        private static EmptyPlayer _instance;

        [XmlIgnore]
        public static EmptyPlayer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmptyPlayer();
                return _instance;
            }
        }

        private EmptyPlayer()
            : base()
        {
            PlayerId = EmptyPlayerId;
            Name = "Empty";
            Surname = "-";
            Nick = "Empty";
            Info = "Virtual BAY player";
            Tag = "BAY";
        }
    }
}