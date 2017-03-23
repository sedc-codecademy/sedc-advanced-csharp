using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Mobsters
{
    static class MobsterHelpers
    {
        public static bool IsNice(this IPayable client)
        {
            return client.Balance > 2000;
        }
    }
}
