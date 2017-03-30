using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class NestedAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NestedNovel> Novels { get; set; }

        public override string ToString()
        {
            return $"#{Id}: {Name}";
        }
    }

    public class NestedNovel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public NestedAuthor Author { get; set; }

        public override string ToString()
        {
            return $"#{Id}: {Title}";
        }
    }

}
