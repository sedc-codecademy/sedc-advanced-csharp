using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Nested
{
    public class NestedAuthor
    {
        public string Name { get; set; }
        public List<NestedNovel> Novels { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class NestedNovel
    {
        public string Title { get; set; }
        public bool IsRead { get; set; }

        public NestedAuthor Author { get; set; }

        public override string ToString()
        {
            return Title;
        }

    }
}
