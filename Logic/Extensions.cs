using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Extensions
{
    public static class Extensions
    {
        private static Random _rnd; 

        static Extensions ()
        {
            _rnd = new Random(DateTime.UtcNow.GetHashCode());
        }

        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            return source.OrderBy<T, int>((item) => _rnd.Next());
        }
    }
}
