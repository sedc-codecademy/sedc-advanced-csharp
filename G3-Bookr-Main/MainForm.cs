using Mapper;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3_Bookr_Main
{
    public partial class MainForm : Form
    {
        private List<Author> authors;
        private List<Novel> novels;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadAuthors(IEnumerable<Author> authors)
        {
            this.authors = authors.ToList();
            DisplayAuthors(this.authors);
        }

        private void DisplayAuthors(IEnumerable<Author> authors)
        {
            lstAuthors.Items.Clear();
            foreach (var author in authors)
            {
                lstAuthors.Items.Add(author);
            }
        }

        private void loadAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.FileName = "authors.json";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    var authors = new JsonAuthorMapper().MapAuthors(text);
                    LoadAuthors(authors);
                }
                catch (IOException ioex)
                {
                    MessageBox.Show(ioex.Message);
                }
            }
        }

        private void loadNovelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.FileName = "novels.json";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    var novels = new JsonAuthorMapper().MapNovels(text);
                    LoadNovels(novels);
                }
                catch (IOException ioex)
                {
                    MessageBox.Show(ioex.Message);
                }
            }
        }

        private void LoadNovels(IEnumerable<Novel> novels)
        {
            this.novels = novels.ToList();
            DisplayNovels(this.novels);
        }

        private void DisplayNovels(IEnumerable<Novel> novels)
        {
            lstNovels.Items.Clear();
            foreach (var novel in novels)
            {
                lstNovels.Items.Add(novel);
            }
        }



        private void lstNovels_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;

            Novel novel = lstNovels.Items[e.Index] as Novel;
            if (novel == null)
                return;
            var brush = new SolidBrush(novel.IsRead ? Color.Gray : Color.Black);
            e.Graphics.DrawString(novel.Title, 
                lstNovels.Font, 
                brush,
                e.Bounds.X,
                e.Bounds.Y);
            e.DrawFocusRectangle();
        }

        private void btnShowAuthor_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtAuthorID.Text);

            var author = authors.First(a => a.ID == id);

            lblAuthor.Text = author.ToString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchTerm = txtAuthorName.Text.ToLowerInvariant();
            var filtered = authors.Where(a => a.Name.ToLowerInvariant().Contains(searchTerm));
            DisplayAuthors(filtered);
        }

        private void lstAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (novels == null)
                return;
            var author = lstAuthors.SelectedItem as Author;
            if (author == null)
                return;
            DisplayAuthorNovels(author);
        }

        private void DisplayAuthorNovels(Author author)
        {
            var filtered = novels.Where(n => n.AuthorId == author.ID);
            DisplayNovels(filtered);
        }

        private void loadNestedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    var authors = new JsonAuthorMapper().MapNestedAuthors(text);

                    NestedAuthors nestedForm = new NestedAuthors();
                    nestedForm.ShowAuthors(authors);
                    nestedForm.ShowDialog();
                }
                catch (IOException ioex)
                {
                    MessageBox.Show(ioex.Message);
                }
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputAuthor.Text))
                return;

            var id = authors.Max(a => a.ID) + 1;

            if (authors.Any(a => a.Name == txtInputAuthor.Text))
                return;

            var author = new Author { Name = txtInputAuthor.Text, ID = id };
            authors.Insert(0, author);
            LoadAuthors(authors);
        }

        private void btnAddNovel_Click(object sender, EventArgs e)
        {
            if (novels == null)
                return;
            if (string.IsNullOrWhiteSpace(txtInputNovel.Text))
                return;
            var author = lstAuthors.SelectedItem as Author;
            if (author == null)
                return;

            var id = novels.Max(n => n.ID) + 1;
            
            if (novels.Any(n => n.Title == txtInputNovel.Text && n.AuthorId == author.ID))
                return;

            var novel = new Novel {
                ID = id,
                Title = txtInputNovel.Text,
                AuthorId = author.ID,
                IsRead = false
            };
            novels.Insert(0, novel);
            DisplayAuthorNovels(author);
        }

    }
}
