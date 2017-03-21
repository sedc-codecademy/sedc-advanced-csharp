using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class CollectionHelper
    {
        //public void PrintArray(int[] array)
        //{
        //    foreach (var item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public void PrintArray(string[] array)
        //{
        //    foreach (var item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public void PrintArray(Dog[] array)
        //{
        //    foreach (var item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        public void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        internal void PrintStack<T>(Stack<T> stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        internal void PrintQueue<T>(Queue<T> queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        //public int GetLastElement(int[] array)
        //{
        //    var index = array.Length-1;
        //    return array[index];
        //}

        //public string GetLastElement(string[] array)
        //{
        //    var index = array.Length - 1;
        //    return array[index];
        //}

        //public Dog GetLastElement(Dog[] array)
        //{
        //    var index = array.Length - 1;
        //    return array[index];
        //}

        public T GetLastElement<T>(T[] array)
        {
            var index = array.Length - 1;
            return array[index];
        }


    }
}
