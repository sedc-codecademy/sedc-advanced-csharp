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

        public IEnumerable<NestedAuthor> Authors { get; internal set; }

        internal void SetAuthors(IEnumerable<NestedAuthor> nauthors)
        {
            Authors = nauthors;
            DisplayAuthors(Authors);
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
    }
}
