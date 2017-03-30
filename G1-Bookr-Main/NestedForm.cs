using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace G1_Bookr_Main
{
    public partial class NestedForm : Form
    {
        public NestedForm()
        {
            InitializeComponent();
        }

        private List<NestedAuthor> authors;

        internal void SetAuthors(IEnumerable<NestedAuthor> nauthors)
        {
            authors = nauthors.ToList();
            DisplayAuthors(authors);
        }

        private void DisplayAuthors(IEnumerable<NestedAuthor> authors)
        {
            lstAuthors.Items.Clear();
            foreach (var author in authors)
            {
                lstAuthors.Items.Add(author);
            }
        }

        private void DisplayNovels(IEnumerable<NestedNovel> novels)
        {
            lstNovels.Items.Clear();
            foreach (var author in novels)
            {
                lstNovels.Items.Add(author);
            }
        }

        private void lstAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var author = lstAuthors.SelectedItem as NestedAuthor;
            if (author == null)
                return;

            DisplayNovels(author.Novels);
        }

        private void btnSaveAuthor_Click(object sender, EventArgs e)
        {
            var name = txtAuthorName.Text;
            if (string.IsNullOrWhiteSpace(name))
                return;
            var id = authors.Max(a => a.Id) + 1;
            var author = new NestedAuthor
            {
                Id = id,
                Name = name,
                Novels = new List<NestedNovel>()
            };
            authors.Insert(0, author);
            DisplayAuthors(authors);
        }

        private void btnSaveNovel_Click(object sender, EventArgs e)
        {
            var title = txtNovelTitle.Text;
            if (string.IsNullOrWhiteSpace(title))
                return;

            var author = lstAuthors.SelectedItem as NestedAuthor;
            if (author == null)
                return;

            var id = authors.SelectMany(a => a.Novels).Max(n => n.Id) + 1;

            var novel = new NestedNovel
            {
                Id = id,
                Title = title,
                Author = author
            };
            author.Novels.Add(novel);
            DisplayNovels(author.Novels);
        }
    }
}
