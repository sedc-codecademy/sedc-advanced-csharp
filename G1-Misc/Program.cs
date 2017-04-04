using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Misc
{
    class Program
    {
        static void Main(string[] args)
        {
            Person weko1 = new Person { FirstName = "Wekoslav", LastName = "Stefanovski" };
            Person weko2 = new Person { FirstName = "Wekoslav", LastName = "Stefanovski" };

            Console.WriteLine(weko1.Equals(weko2));

            Car myCar = new Car { Make = "Zastava", Model = "101 Comfort" };
            Car petarCar = new Car { Make = "Zastava", Model = "101 Comfort" };

            Console.WriteLine(myCar.Equals(petarCar));

            Point p1 = new Point { X = 3, Y = 4 };
            Point p2 = new Point { X = 3, Y = 4 };

            Console.WriteLine(p1.Equals(p2));

            var myCar2 = myCar;
            myCar2.Make = "Lamborgini";

            ChangeCar(myCar);
            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);

            ChangePoint(ref p1);
            Console.WriteLine(p1.X);
            Console.WriteLine(p1.Y);

            string s1 = "Wekoslav";
            string s2 = "Wekoslav";

            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 300000; i++)
            {
                s1 += "-";
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            sw = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            sb.Append("Wekoslav");
            for (int i = 0; i < 300000; i++)
            {
                sb.Append("-");
            }
            s2 = sb.ToString();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine(s1.Equals(s2));
        }

        static void ChangeCar(Car c)
        {
            c.Model = "Diablo";
        }

        static void ChangePoint(ref Point p)
        {
            p.Y = 100;
        }

    }
}
