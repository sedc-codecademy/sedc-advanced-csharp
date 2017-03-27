namespace G3_Bookr_Main
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstAuthors = new System.Windows.Forms.ListBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.lstNovels = new System.Windows.Forms.ListBox();
            this.loadNovelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHereToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1015, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuHereToolStripMenuItem
            // 
            this.menuHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAuthorsToolStripMenuItem,
            this.loadNovelsToolStripMenuItem});
            this.menuHereToolStripMenuItem.Name = "menuHereToolStripMenuItem";
            this.menuHereToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuHereToolStripMenuItem.Text = "File";
            // 
            // loadAuthorsToolStripMenuItem
            // 
            this.loadAuthorsToolStripMenuItem.Name = "loadAuthorsToolStripMenuItem";
            this.loadAuthorsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadAuthorsToolStripMenuItem.Text = "Load Authors";
            this.loadAuthorsToolStripMenuItem.Click += new System.EventHandler(this.loadAuthorsToolStripMenuItem_Click);
            // 
            // lstAuthors
            // 
            this.lstAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAuthors.FormattingEnabled = true;
            this.lstAuthors.ItemHeight = 25;
            this.lstAuthors.Location = new System.Drawing.Point(21, 36);
            this.lstAuthors.Name = "lstAuthors";
            this.lstAuthors.Size = new System.Drawing.Size(302, 529);
            this.lstAuthors.TabIndex = 1;
            // 
            // openDialog
            // 
            this.openDialog.Filter = "JSON files | *.json";
            // 
            // lstNovels
            // 
            this.lstNovels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstNovels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNovels.FormattingEnabled = true;
            this.lstNovels.ItemHeight = 25;
            this.lstNovels.Location = new System.Drawing.Point(356, 38);
            this.lstNovels.Name = "lstNovels";
            this.lstNovels.Size = new System.Drawing.Size(302, 529);
            this.lstNovels.TabIndex = 2;
            // 
            // loadNovelsToolStripMenuItem
            // 
            this.loadNovelsToolStripMenuItem.Name = "loadNovelsToolStripMenuItem";
            this.loadNovelsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadNovelsToolStripMenuItem.Text = "Load Novels";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 611);
            this.Controls.Add(this.lstNovels);
            this.Controls.Add(this.lstAuthors);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "OOP with C# - Bookr";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuHereToolStripMenuItem;
        private System.Windows.Forms.ListBox lstAuthors;
        private System.Windows.Forms.ToolStripMenuItem loadAuthorsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ListBox lstNovels;
        private System.Windows.Forms.ToolStripMenuItem loadNovelsToolStripMenuItem;
    }
}

