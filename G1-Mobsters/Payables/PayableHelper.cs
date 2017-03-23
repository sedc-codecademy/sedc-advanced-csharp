using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Mobsters.Payables
{
    static class PayableHelper
    {
        public static int TakeCharity(this IPayable client)
        {
            if (client.Balance < 600)
            {
                if (client.Balance < 300)
                {
                    client.Deposit(300);
                    return 300;
                }
                else
                {
                    var charity = client.Balance;
                    client.Deposit(charity);
                    return charity;
                }
            }
            return 0;
        }
    }
}
