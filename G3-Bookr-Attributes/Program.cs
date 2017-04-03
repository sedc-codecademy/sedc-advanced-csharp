using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Bookr_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeFlagValue sfv = SomeFlagValue.OptionFive | SomeFlagValue.OptionFour | SomeFlagValue.OptionOne;
            Console.WriteLine(sfv);
        }
    }
}
