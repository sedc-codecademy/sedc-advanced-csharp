using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional
{
    internal static class ListHelper
    {
        public static void PrintList<T>(this List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        internal static T GetLastElement<T>(this List<T> list)
        {
            if (list.Count == 0)
                return default(T);

            var index = list.Count - 1;
            return list[index];
        }

        internal static List<T> Filter<T>(this List<T> list, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (var item in list)
            {
                if (predicate(item))
                    result.Add(item);
            }
            return result;
        }

        internal static List<U> Map<T, U>(this List<T> list, Func<T, U> selector)
        {
            List<U> result = new List<U>();
            foreach (var item in list)
            {
                result.Add(selector(item));
            }
            return result;
        }
    }
}
