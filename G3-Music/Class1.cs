using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Music
{
    public class Musician
    {

        public string Name { get; set; }
        public List<Album> Albums{ get; set; }
    }

    public class Album
    {
        public string Name { get; set; }
    }
}
