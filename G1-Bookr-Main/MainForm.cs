using Entities;
using Parser;
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

namespace G1_Bookr_Main
{
    public partial class MainForm : Form
    {
        private List<Author> authors;
        private List<Novel> novels;

        public MainForm()
        {
            InitializeComponent();
            authors = new List<Author>();
            novels = new List<Novel>();
        }

        private void DisplayAuthors(IEnumerable<Author> authors)
        {
            lstAuthors.Items.Clear();
            foreach (var author in authors)
            {
                lstAuthors.Items.Add(author);
            }
        }

        private void DisplayNovels(IEnumerable<Novel> novels)
        {
            lstNovels.Items.Clear();
            foreach (var author in novels)
            {
                lstNovels.Items.Add(author);
            }
        }

        private void loadAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "authors.json";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    JsonParser parser = new JsonParser();
                    authors = parser.ParseAuthors(text).ToList();
                    DisplayAuthors(authors);

                }
                catch (IOException ioex)
                {
                    MessageBox.Show("Unable to open file: " + ioex.Message);
                }

            }
        }

        private void loadNovelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "novels.json";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    JsonParser parser = new JsonParser();
                    novels = parser.ParseNovels(text).ToList();
                    DisplayNovels(novels);
                }
                catch (IOException ioex)
                {
                    MessageBox.Show("Unable to open file: " + ioex.Message);
                }

            }
        }

        private void lstNovels_DrawItem(object sender, DrawItemEventArgs e)
        {
            // based on http://stackoverflow.com/questions/25937721/c-sharp-listbox-ownerdrawfixedmode-scrolling-doesnt-show-list-properly
            Novel novel = lstNovels.Items[e.Index] as Novel; // Get the current item and cast it to MyListBoxItem
            if (novel == null)
                return;
            
            var brush = novel.IsRead ? new SolidBrush(Color.Gray) : new SolidBrush(Color.Black); // Set the color 
            e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                novel.ToString(), // The message linked to the item
                lstNovels.Font, // Take the font from the listbox
                brush,
                e.Bounds.X, // X pixel coordinate
                e.Bounds.Y // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
            );
            
        }

        private void btnGetAuthor_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtFindAuthorId.Text);
            var author = authors.SingleOrDefault(a => a.Id == id);
            if (author == null)
                return;

            lblAuthor.Text = $"ID = {author.Id}" + Environment.NewLine +
                             $"Name = {author.FullName}" + Environment.NewLine +
                             $"Country = {author.Country}";

        }

        private void btnFindAuthors_Click(object sender, EventArgs e)
        {
            var searchTerm = txtFindAuthorName.Text.ToLowerInvariant();
            if (string.IsNullOrWhiteSpace(searchTerm))
                return;
            var filtered = authors.Where(a => a.FullName.ToLowerInvariant().Contains(searchTerm));
            DisplayAuthors(filtered);
        }

        private void lstAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var author = lstAuthors.SelectedItem as Author;
            if (author == null)
                return;
            var authorId = author.Id;
            var filtered = novels.Where(n => n.AuthorId == authorId);
            DisplayNovels(filtered);
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            AuthorManager am = new AuthorManager();
            var nauthors = am.TransformData(authors, novels);
            NestedForm nf = new NestedForm();
            nf.SetAuthors(nauthors);
            nf.ShowDialog();

        }
    }
}
