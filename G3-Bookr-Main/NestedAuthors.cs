using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Nested;

namespace G3_Bookr_Main
{
    public partial class NestedAuthors : Form
    {
        public NestedAuthors()
        {
            InitializeComponent();
        }

        public List<NestedAuthor> Authors { get; internal set; }

        internal void ShowAuthors(IEnumerable<NestedAuthor> authors)
        {
            Authors = authors.ToList();
            lstAuthors.Items.Clear();
            foreach (var author in Authors)
            {
                lstAuthors.Items.Add(author);
            }
        }

        private void lstAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var author = lstAuthors.SelectedItem as NestedAuthor;
            if (author == null)
                return;

            lstNovels.Items.Clear();
            foreach (var novel in author.Novels)
            {
                lstNovels.Items.Add(novel);
            }
        }

        private void btnWarPeace_Click(object sender, EventArgs e)
        {
            var tolstoy = new NestedAuthor { Name = "Lev Tolstoy", Novels = new List<NestedNovel>() };
            var warPeace = new NestedNovel { Title = "War and peace" };

            tolstoy.Novels.Add(warPeace);
            warPeace.Author = tolstoy;

            Authors.Add(tolstoy);
            ShowAuthors(Authors);
        }
    }
}
