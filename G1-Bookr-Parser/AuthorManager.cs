using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class AuthorManager
    {
        public IEnumerable<NestedAuthor> TransformData(IEnumerable<Author> authors, IEnumerable<Novel> novels)
        {
            var nauthors = authors.Select(a => new NestedAuthor
            {
                Id = a.Id,
                Name = a.Name
            }).ToList();

            foreach (var author in nauthors)
            {
                var nnovels = novels
                    .Where(n => n.AuthorId == author.Id)
                    .Select(n => new NestedNovel
                    {
                        Id = n.Id,
                        Title = n.Title,
                        Author = author
                    });
                foreach (var nnovel in nnovels)
                {
                    author.AddNovel(nnovel);
                }
            }

            foreach(var nauthor in nauthors.Where(n => n.Name.StartsWith("Edgar")))
            {
                nauthor.NovelAdded += NotifyCensors;
            }

            return nauthors;
        }

        private static void NotifyCensors(object sender, NovelAddedEventArgs e)
        {
            Console.WriteLine($"New book for censoring: {e.Title} by {e.Author}");
        }

    }
}
