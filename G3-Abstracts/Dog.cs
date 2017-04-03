using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Abstracts
{
    public class Dog : Animal
    {
        public bool IsLarge { get; set; }

        public override string MakeSound()
        {
            if (IsLarge)
                return "Woof!";
            else
                return "Yap! Yap! Yap!";
        }
    }
}
