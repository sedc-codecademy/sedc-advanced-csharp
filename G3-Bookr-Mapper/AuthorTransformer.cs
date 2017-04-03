using Model;
using Model.Nested;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class AuthorTransformer
    {
        public IEnumerable<NestedAuthor> SeparateToNested(IEnumerable<Author> authors, IEnumerable<Novel> novels)
        {
            var result = authors.Select(a => new NestedAuthor
            {
                Id = a.ID,
                Name = a.Name
            }).ToList();

            foreach (var nauthor in result)
            {
                var authorNovels = novels
                    .Where(n => n.AuthorId == nauthor.Id)
                    .Select(n => new NestedNovel
                    {
                        Id = n.ID,
                        IsRead = n.IsRead,
                        Title = n.Title,
                        Author = nauthor
                    });

                foreach (var novel in authorNovels)
                {
                    nauthor.AddNovel(novel);
                }
            }

            var edgars = result.Where(a => a.Name.StartsWith("Edgar"));

            foreach (var edgar in edgars)
            {
                edgar.NovelAdded += Edgar_NovelAdded;

            }

            return result;
        }

        private void Edgar_NovelAdded(object sender, NovelAddedEventArgs e)
        {
            Console.WriteLine($"An Edgar - {e.AuthorName} has published a novel, run awayyyy");
        }
    }
}
