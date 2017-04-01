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

        public event EventHandler<NovelAddedEventArgs> NovelAdded;

        private List<NestedNovel> novels = new List<NestedNovel>();

        public IEnumerable<NestedNovel> Novels
        {
            get
            {
                return novels.AsReadOnly();
            }
        }


        public void AddNovel(NestedNovel novel)
        {
            novels.Add(novel);
            NovelAdded?.Invoke(this, new NovelAddedEventArgs
            {
                Title = novel.Title,
                Author = Name
            });
        }

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

    public class NovelAddedEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

}
