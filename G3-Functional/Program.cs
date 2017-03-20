using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> list = Enumerable.Range(1, 100).ToList();
            //ListHelper.PrintList(list);

            //Console.WriteLine(list[0]);
            //list.Add(101);
            //list.Insert(0, -100);

            //var stack = new Stack<int>();
            //for (int i = 0; i < 20; i++)
            //{
            //    stack.Push(i);
            //}

            //while (stack.Count != 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //var queue = new Queue<int>();
            //for (int i = 0; i < 20; i++)
            //{
            //    queue.Enqueue(i);
            //}

            //while (queue.Count != 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //var set = new HashSet<int>();
            //set.Add(5);
            //set.Add(5);
            //set.Add(5);
            //set.Add(5);
            //set.Add(5);
            //Console.WriteLine(set.Count);

            //var numbers = new Dictionary<int, string>
            //{
            //    { 1, "one"},
            //    { 2, "two"},
            //    { 3, "three" },
            //    { 4, "four" },
            //    { 5, "five" },
            //    { 6, "six" },
            //    { 7, "seven" },
            //    { 8, "eight" },
            //    { 9, "nine" },
            //    { 0, "zero" },
            //};

            //var num = 1238275983465743;

            Func<int, int> square = x => x * x;
            //Func<int, int, int> add = (x, y) => x + y;

            //Action<int> writeNum = x => Console.WriteLine(x);

            //writeNum(square(3));

            List<int> list = Enumerable.Range(1, 100).ToList();
            //helper.PrintList(list);

            //var target = list
            //    .Where(i => i % 2 != 0)
            //    .Select(square)
            //    .Skip(10)
            //    .Take(20)
            //    .ToList();
            //helper.PrintList(target);

            //var target = ListHelper.Map(ListHelper.Filter(list, i => i % 2 != 0), x => x * x);
            //var target = list.Filter(i => i % 2 != 0).Map(x => x * x).Skip(10).Take(4).OrderBy(x => x % 10);

            var target = list
                .Filter(i => i % 2 != 0)
                .Map(x => x * x)
                .Skip(10)
                .Take(4)
                .OrderBy(x => x % 10);

            //var target = Enumerable.OrderBy(Enumerable.Take(Enumerable.Skip(ListHelper.Map(ListHelper.Filter(list, i => i % 2 != 0), x => x * x), 10), 4), x => x % 10);

            //var target = from i in list
            //             where i % 2 != 0
            //             select i * i;

            target.ToList().PrintList();
        }

        public int Square(int number)
        {
            return number * number;
        }
    }
}
