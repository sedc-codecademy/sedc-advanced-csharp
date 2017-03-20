using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Interface
{
    interface IPayable
    {
        int Price { get; set; }
        int Balance { get; }
        void Withdraw(int ammount);
    }
}
