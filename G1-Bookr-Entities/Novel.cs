using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Novel
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public bool IsRead { get; set; }
        public int? Pages { get; set; }

        public override string ToString()
        {
            return $"#{Id}: {Title}";
        }
    }
}
