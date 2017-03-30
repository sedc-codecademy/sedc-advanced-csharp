using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Bookr_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var author = new NestedAuthor
            {
                Id = 1,
                Name = "Kim Stanley Robinson",
                Novels = new List<NestedNovel>()
            };

            var novel = new NestedNovel
            {
                Id = 1,
                Title = "Red Mars",
                Author = author
            };

            author.Novels.Add(novel);

        }
    }
}
