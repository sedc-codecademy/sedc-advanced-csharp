using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Nested
{
    public class NestedAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }

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
            if (NovelAdded != null)
            {
                NovelAdded(this, new NovelAddedEventArgs {
                    Title = novel.Title,
                    AuthorName = this.Name
                });
            }
        }

        public event EventHandler<NovelAddedEventArgs> NovelAdded;

        public override string ToString()
        {
            return Name;
        }
    }

    public class NovelAddedEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
    }

    public class NestedNovel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsRead { get; set; }

        public NestedAuthor Author { get; set; }

        public override string ToString()
        {
            return Title;
        }

    }
}
