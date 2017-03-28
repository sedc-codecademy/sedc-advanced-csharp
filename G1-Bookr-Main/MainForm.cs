using Entities;
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

        private void DisplayAuthors(List<Author> authors)
        {
            lstAuthors.Items.Clear();
            foreach (var author in authors)
            {
                lstAuthors.Items.Add(author);
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar + " was pressed");
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
                    txtFileDisplay.Text = text;
                }
                catch (IOException ioex)
                {
                    MessageBox.Show("Unable to open file: " + ioex.Message);
                }

            }
        }
    }
}
