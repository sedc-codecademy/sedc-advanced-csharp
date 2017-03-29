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
            this.loadNovelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstAuthors = new System.Windows.Forms.ListBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.lstNovels = new System.Windows.Forms.ListBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.btnShowAuthor = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHereToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.mainMenu.Size = new System.Drawing.Size(1169, 27);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuHereToolStripMenuItem
            // 
            this.menuHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAuthorsToolStripMenuItem,
            this.loadNovelsToolStripMenuItem});
            this.menuHereToolStripMenuItem.Name = "menuHereToolStripMenuItem";
            this.menuHereToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.menuHereToolStripMenuItem.Text = "File";
            // 
            // loadAuthorsToolStripMenuItem
            // 
            this.loadAuthorsToolStripMenuItem.Name = "loadAuthorsToolStripMenuItem";
            this.loadAuthorsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.loadAuthorsToolStripMenuItem.Text = "Load Authors";
            this.loadAuthorsToolStripMenuItem.Click += new System.EventHandler(this.loadAuthorsToolStripMenuItem_Click);
            // 
            // loadNovelsToolStripMenuItem
            // 
            this.loadNovelsToolStripMenuItem.Name = "loadNovelsToolStripMenuItem";
            this.loadNovelsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.loadNovelsToolStripMenuItem.Text = "Load Novels";
            this.loadNovelsToolStripMenuItem.Click += new System.EventHandler(this.loadNovelsToolStripMenuItem_Click);
            // 
            // lstAuthors
            // 
            this.lstAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAuthors.FormattingEnabled = true;
            this.lstAuthors.ItemHeight = 25;
            this.lstAuthors.Location = new System.Drawing.Point(15, 33);
            this.lstAuthors.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstAuthors.Name = "lstAuthors";
            this.lstAuthors.Size = new System.Drawing.Size(270, 429);
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
            this.lstNovels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstNovels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNovels.FormattingEnabled = true;
            this.lstNovels.ItemHeight = 25;
            this.lstNovels.Location = new System.Drawing.Point(309, 33);
            this.lstNovels.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstNovels.Name = "lstNovels";
            this.lstNovels.Size = new System.Drawing.Size(292, 429);
            this.lstNovels.TabIndex = 2;
            this.lstNovels.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstNovels_DrawItem);
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(666, 33);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(100, 31);
            this.txtAuthorID.TabIndex = 3;
            // 
            // btnShowAuthor
            // 
            this.btnShowAuthor.Location = new System.Drawing.Point(773, 33);
            this.btnShowAuthor.Name = "btnShowAuthor";
            this.btnShowAuthor.Size = new System.Drawing.Size(170, 31);
            this.btnShowAuthor.TabIndex = 4;
            this.btnShowAuthor.Text = "Show Author";
            this.btnShowAuthor.UseVisualStyleBackColor = true;
            this.btnShowAuthor.Click += new System.EventHandler(this.btnShowAuthor_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(949, 39);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(70, 25);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "label1";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(666, 139);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(100, 31);
            this.txtAuthorName.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(773, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 31);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Author";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 492);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnShowAuthor);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.lstNovels);
            this.Controls.Add(this.lstAuthors);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Button btnShowAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Button btnSearch;
    }
}

