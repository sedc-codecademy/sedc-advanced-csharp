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
        //private JsonParser parser = new JsonParser();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerateAuthors_Click(object sender, EventArgs e)
        {
            List<Author> authors = new List<Author>
            {
                new Author { Name = "Arthur Clarke" },
                new Author { Name = "Isaak Asimov" },
                new Author { Name = "Ray Bradbury" },
                new Author { Name = "Robert Heinlein" },
                new Author { Name = "Philip Dick" }
            };

            DisplayAuthors(authors);
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
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    JsonParser parser = new JsonParser();
                    var authors = parser.ParseAuthors(text);
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
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    JsonParser parser = new JsonParser();
                    var novels = parser.ParseNovels(text);
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
            var brush = novel.IsRead ? new SolidBrush(Color.Gray) : new SolidBrush(Color.Black); // Set the color 
            if (novel != null)
            {
                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    novel.ToString(), // The message linked to the item
                    lstNovels.Font, // Take the font from the listbox
                    brush,
                    e.Bounds.X, // X pixel coordinate
                    e.Bounds.Y // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
            }
        }
    }
}
