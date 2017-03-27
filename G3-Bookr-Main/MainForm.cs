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
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerateAuthors_Click(object sender, EventArgs e)
        {
            List<Author> authors = new List<Author>()
            {
                new Author { Name = "Arthur C. Clarke" },
                new Author { Name = "Isaac Asimov" },
                new Author { Name = "Robert Heinlein" },
                new Author { Name = "J.K. Rowling" }
            };

            LoadAuthors(authors);

        }

        private void LoadAuthors(IEnumerable<Author> authors)
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

    }
}
