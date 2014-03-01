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

		/// <summary>
		/// Randomly reorder sequence
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <returns></returns>
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            return source.OrderBy<T, int>((item) => _rnd.Next());
        }
    }
}
