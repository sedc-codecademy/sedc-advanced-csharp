using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    static class ListHelper
    {
        public static List<U> CalculateList<T, U>(this List<T> list, Func<T, U> operation)
        {
            var result = new List<U>();
            foreach (var item in list)
            {
                var itemResult = operation(item);
                result.Add(itemResult);
            }
            return result;
        }

        public static List<T> EvaluateCondition<T>(this List<T> list, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var item in list)
            {
                if (predicate(item))
                    result.Add(item);
            }
            return result;
        }

        public static void PrintList<T>(this List<T> list)
        {
            Console.WriteLine("-------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
        }
    }
}
