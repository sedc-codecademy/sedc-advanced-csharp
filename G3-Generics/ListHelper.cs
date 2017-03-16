using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ListHelper
    {
        public void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        internal T GetLastElement<T>(List<T> list)
        {
            if (list.Count == 0)
                return default(T);

            var index = list.Count - 1;
            return list[index];
        }
    }
}
