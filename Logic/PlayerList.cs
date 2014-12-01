using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logic
{
    /// <summary>
    /// Globally defined players data
    /// </summary>
    public class PlayerList : ICollection<Player>, IDisposable, INotifyPropertyChanged
    {
        #region Props

        public static PlayerList Instance
        {
            get
            {
                return _instance;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public IList<Player> Players
        {
            get { return _players.Values.ToList(); }
        }

        #endregion Props

        #region fields

        private const string PLAYERS_FILE_NAME = "Players.dat";

        private static PlayerList _instance;

        private Dictionary<int, Player> _players = new Dictionary<int, Player>();

        private FileStream _playersFile;
        private XmlSerializer serializer;

        #endregion fields

        #region ctor

        static PlayerList()
        {
            _instance = new PlayerList();
        }

        private PlayerList()
        {
            serializer = new XmlSerializer(typeof(List<Player>));
        }

        #endregion ctor

        public bool LoadPlayerList()
        {
            try
            {
                if (!File.Exists(PLAYERS_FILE_NAME))
                {
                    _playersFile = File.Open(PLAYERS_FILE_NAME, FileMode.Create);
                }
                else
                {
                    _playersFile = File.Open(PLAYERS_FILE_NAME, FileMode.Open);

                    List<Player> players = new List<Player>();
                    players.AddRange((IEnumerable<Player>)serializer.Deserialize(_playersFile));

                    foreach (var item in players)
                    {
                        _players.Add(item.PlayerId, item);
                    }
                }

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Players"));

                return true;
            }
            catch (Exception exc)
            {
                Trace.WriteLine(exc.ToString());
                return false;
            }
            finally
            {
                _playersFile.Close();
            }
        }

        public void SavePlayerList()
        {
            Task.Run(() =>
                {
                    try
                    {
                        _playersFile = File.Open(PLAYERS_FILE_NAME, FileMode.Create);

                        serializer.Serialize(_playersFile, Players);
                    }
                    catch (Exception exc)
                    {
                        Trace.WriteLine(exc.ToString());
                    }
                    finally
                    {
                        _playersFile.Close();
                    }
                }
            );
        }

        #region IList

        public Player this[int i]
        {
            get
            {
                if (!_players.ContainsKey(i))
                    return null;
                else
                    return _players[i];
            }
        }

        public IEnumerator<Player> GetEnumerator()
        {
            return _players.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _players.Values.GetEnumerator();
        }

        public void Add(Player item)
        {
            if (_players.Count == 0)
                item.PlayerId = 1;
            else
                item.PlayerId = Players.Max(n => n.PlayerId) + 1;

            _players.Add(item.PlayerId, item);

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Players"));

            SavePlayerList();
        }

        public void Clear()
        {
            _players.Clear();

            SavePlayerList();
        }

        public bool Contains(Player item)
        {
            return _players.ContainsKey(item.PlayerId);
        }

        public void CopyTo(Player[] array, int arrayIndex)
        {
            _players.Values.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _players.Count; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public bool Remove(Player item)
        {
            try
            {
                return _players.Remove(item.PlayerId);
            }
            finally
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Players"));
                SavePlayerList();
            }
        }

        #endregion IList

        public void Dispose()
        {
            if (_playersFile == null)
                return;

            _playersFile.Close();
            _playersFile.Dispose();
        }
    }
}