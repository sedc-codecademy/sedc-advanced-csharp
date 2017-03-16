using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayWithGenerics();
            CollectionsDemo();
        }

        private static void CollectionsDemo()
        {
            var helper = new CollectionHelper();
            var list = new List<int>();
            list.Add(2);
            list.Insert(0, 3);
            list.Insert(1, 7);
            Console.WriteLine($"List: {list.Count} elements found");
            helper.PrintList(list);
            list.Insert(1, 7);
            Console.WriteLine($"List: {list.Count} elements found");
            helper.PrintList(list);

            var stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            var pop = stack.Pop();
            Console.WriteLine($"Popped {pop}");

            Console.WriteLine($"Stack: {stack.Count} elements found");
            helper.PrintStack(stack);

            var queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            var first = queue.Dequeue();
            Console.WriteLine($"Dequeued {first}");

            Console.WriteLine($"Queue: {queue.Count} elements found");
            helper.PrintQueue(queue);

            var set = new HashSet<int>();
            set.Add(3);
            set.Add(7);
            set.Add(5);
            set.Add(3);

            Console.WriteLine($"Set: {set.Count} elements found");

            var dict = new Dictionary<int, string>();

            dict.Add(1, "One");
            dict.Add(2, "Two");

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key * 2);
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var dict2 = new Dictionary<string, Dog>();

            foreach (var item in dict2)
            {
                Console.WriteLine(item.Key.ToLower());
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static void ArrayWithGenerics()
        {
            var helper = new CollectionHelper();

            int[] numbers = { 1, 2, 3, 4, 5 };
            helper.PrintArray(numbers);
            Console.WriteLine($"Last is: {helper.GetLastElement(numbers)}");

            string[] students =
            {
                "Aneta",
                "Nenad",
                "Petar",
                "Marjan"
            };
            helper.PrintArray(students);
            Console.WriteLine($"Last is: {helper.GetLastElement(students)}");

            Dog[] doges =
            {
                new Dog {Name ="Rex", Age=3 },
                new Dog {Name ="Leo", Age = 2 }
            };

            helper.PrintArray(doges);
            Console.WriteLine($"Last is: {helper.GetLastElement(doges)}");
        }
    }
}
