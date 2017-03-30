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
                Name = a.Name,
                Novels = null
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
                author.Novels = nnovels.ToList();
            }

            return nauthors;
        }
    }
}
