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
        private IEnumerable<Author> authors;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadAuthors(IEnumerable<Author> authors)
        {
            this.authors = authors;
            DisplayAuthors();
        }

        private void DisplayAuthors()
        {
            lstAuthors.Items.Clear();
            foreach (var author in authors)
            {
                lstAuthors.Items.Add(author);
            }
        }

        private void loadAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}
