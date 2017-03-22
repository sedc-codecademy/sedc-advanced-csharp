using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Mobsters
{
    public interface IPayable
    {
        int Price { get; set; }
        int Balance { get; }
    }
}
