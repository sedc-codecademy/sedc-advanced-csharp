using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Documentation]
    public class Author
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int NovelsCount { get; set; }

        public string Country { get; set; }

        public override string ToString()
        {
            return $"#{Id}: {FullName}";
        }
    }

    [Flags]
    public enum Options
    {
        Default = 0,
        OptionOne = 1,
        OptionTwo = 2,
        OptionThree = 4,
        OptionFour = 8
    }
}
