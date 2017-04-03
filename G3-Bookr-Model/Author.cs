using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Author
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"#{ID}: {Name}";
        }
    }

    [Flags]
    public enum SomeFlagValue
    {
        Default = 0,
        OptionOne = 1,
        OptionTwo = 2,
        OptionThree = 4,
        OptionFour = 8,
        OptionFive = 16,
    }

}
