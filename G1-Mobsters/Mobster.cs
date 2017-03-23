using G1_Mobsters.Payables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Mobsters
{
    public class Mobster
    {
        public string Name { get; set; }
        public string Nickname { get; set; }

        List<IPayable> clients;

        public Mobster(string name, string nickname)
        {
            Name = name;
            Nickname = nickname;
            clients = new List<IPayable>();
        }

        public override string ToString()
        {
            return $"I'm {Name} the {Nickname}";
        }

        public void AddClient(IPayable client)
        {
            clients.Add(client);
        }

    }
}
