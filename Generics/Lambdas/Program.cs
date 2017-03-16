using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 3, 6, 5, 9, 12 };
            ListHelper.PrintList(list);

            Func<int, int> doSquare = x => x * x;
            var squares = ListHelper.CalculateList(list, doSquare);
            ListHelper.PrintList(squares);

            var doubles = ListHelper.CalculateList(list, x => x * 2);
            ListHelper.PrintList(doubles);

            var isevens = ListHelper.CalculateList(list, x => x % 2 == 0);
            ListHelper.PrintList(isevens);

            ListHelper.PrintList(ListHelper.CalculateList(list, x => x + 1));

            ListHelper.PrintList(ListHelper.EvaluateCondition(list, x => x % 2 == 0));

            ListHelper.PrintList(ListHelper.EvaluateCondition(list, x => x > 4));


            ListHelper.PrintList(ListHelper.CalculateList(ListHelper.EvaluateCondition(list, x => x > 4), x => x * x));


            list.EvaluateCondition(x => x > 4).CalculateList(x => x * x).PrintList();

            //var evens = new List<int>();
            //foreach (var item in list)
            //{
            //    if (item % 2 == 0)
            //        evens.Add(item);
            //}

            //ListHelper.PrintList(evens);

            //var biggerThanFour = new List<int>();
            //foreach (var item in list)
            //{
            //    if (item > 4)
            //        biggerThanFour.Add(item);
            //}

            //ListHelper.PrintList(biggerThanFour);


            //var doubles = new List<int>();
            //foreach (var number in list)
            //{
            //    doubles.Add(number * 2);
            //}
            //PrintList(doubles);

            //var isevens = new List<bool>();
            //foreach (var number in list)
            //{
            //    isevens.Add(number % 2 == 0);
            //}
            //PrintList(isevens);
        }



    }
}
