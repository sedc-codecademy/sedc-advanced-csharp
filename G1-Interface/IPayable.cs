using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Interface
{
    interface IPayable
    {
        int Price { get; set; }
        int Balance { get; }

        int Withdraw(int ammount);
    }
}
