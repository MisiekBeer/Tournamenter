using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PlayerList : IEnumerable<Player>
    {
        public static PlayerList Instance
        {
            get {                     
                return _instance;
            }
        }

        private static PlayerList _instance;

        private static Dictionary<int, Player> _players = new Dictionary<int, Player>();

        static PlayerList()
        {
            _instance = new PlayerList();
        }


        private PlayerList()
        {

        }

        public bool LoadPlayerList()
        {
            return true;
        }

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

        public bool AddNewPlayer()
        {
            return true;
        }

        public bool RemovePlayer()
        {
            return true;
        }

        public IEnumerator<Player> GetEnumerator()
        {
            return _players.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _players.Values.GetEnumerator();
        }
    }
}
