using System;

namespace G1_Bookr_Main
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
            this.lstAuthors = new System.Windows.Forms.ListBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNovelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstNovels = new System.Windows.Forms.ListBox();
            this.btnGetAuthor = new System.Windows.Forms.Button();
            this.txtFindAuthorId = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtFindAuthorName = new System.Windows.Forms.TextBox();
            this.btnFindAuthors = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAuthors
            // 
            this.lstAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAuthors.FormattingEnabled = true;
            this.lstAuthors.ItemHeight = 25;
            this.lstAuthors.Location = new System.Drawing.Point(33, 20);
            this.lstAuthors.Margin = new System.Windows.Forms.Padding(6);
            this.lstAuthors.Name = "lstAuthors";
            this.lstAuthors.Size = new System.Drawing.Size(302, 554);
            this.lstAuthors.TabIndex = 3;
            this.lstAuthors.SelectedIndexChanged += new System.EventHandler(this.lstAuthors_SelectedIndexChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1144, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAuthorsToolStripMenuItem,
            this.loadNovelsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadAuthorsToolStripMenuItem
            // 
            this.loadAuthorsToolStripMenuItem.Name = "loadAuthorsToolStripMenuItem";
            this.loadAuthorsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadAuthorsToolStripMenuItem.Text = "Load Authors ...";
            this.loadAuthorsToolStripMenuItem.Click += new System.EventHandler(this.loadAuthorsToolStripMenuItem_Click);
            // 
            // loadNovelsToolStripMenuItem
            // 
            this.loadNovelsToolStripMenuItem.Name = "loadNovelsToolStripMenuItem";
            this.loadNovelsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadNovelsToolStripMenuItem.Text = "Load Novels ...";
            this.loadNovelsToolStripMenuItem.Click += new System.EventHandler(this.loadNovelsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select json file";
            // 
            // lstNovels
            // 
            this.lstNovels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstNovels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstNovels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNovels.FormattingEnabled = true;
            this.lstNovels.ItemHeight = 25;
            this.lstNovels.Location = new System.Drawing.Point(338, 23);
            this.lstNovels.Margin = new System.Windows.Forms.Padding(6);
            this.lstNovels.Name = "lstNovels";
            this.lstNovels.Size = new System.Drawing.Size(429, 554);
            this.lstNovels.TabIndex = 5;
            this.lstNovels.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstNovels_DrawItem);
            // 
            // btnGetAuthor
            // 
            this.btnGetAuthor.Location = new System.Drawing.Point(983, 27);
            this.btnGetAuthor.Name = "btnGetAuthor";
            this.btnGetAuthor.Size = new System.Drawing.Size(149, 31);
            this.btnGetAuthor.TabIndex = 6;
            this.btnGetAuthor.Text = "Get Author";
            this.btnGetAuthor.UseVisualStyleBackColor = true;
            this.btnGetAuthor.Click += new System.EventHandler(this.btnGetAuthor_Click);
            // 
            // txtFindAuthorId
            // 
            this.txtFindAuthorId.Location = new System.Drawing.Point(800, 27);
            this.txtFindAuthorId.Name = "txtFindAuthorId";
            this.txtFindAuthorId.Size = new System.Drawing.Size(177, 31);
            this.txtFindAuthorId.TabIndex = 7;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(800, 74);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(0, 25);
            this.lblAuthor.TabIndex = 8;
            // 
            // txtFindAuthorName
            // 
            this.txtFindAuthorName.Location = new System.Drawing.Point(800, 185);
            this.txtFindAuthorName.Name = "txtFindAuthorName";
            this.txtFindAuthorName.Size = new System.Drawing.Size(177, 31);
            this.txtFindAuthorName.TabIndex = 10;
            // 
            // btnFindAuthors
            // 
            this.btnFindAuthors.Location = new System.Drawing.Point(983, 185);
            this.btnFindAuthors.Name = "btnFindAuthors";
            this.btnFindAuthors.Size = new System.Drawing.Size(149, 31);
            this.btnFindAuthors.TabIndex = 9;
            this.btnFindAuthors.Text = "Find Authors";
            this.btnFindAuthors.UseVisualStyleBackColor = true;
            this.btnFindAuthors.Click += new System.EventHandler(this.btnFindAuthors_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(800, 253);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(332, 63);
            this.btnTransform.TabIndex = 11;
            this.btnTransform.Text = "Transform Data";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 589);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.txtFindAuthorName);
            this.Controls.Add(this.btnFindAuthors);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtFindAuthorId);
            this.Controls.Add(this.btnGetAuthor);
            this.Controls.Add(this.lstNovels);
            this.Controls.Add(this.lstAuthors);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Group 1 - BookR - Main Form";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstAuthors;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNovelsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstNovels;
        private System.Windows.Forms.Button btnGetAuthor;
        private System.Windows.Forms.TextBox txtFindAuthorId;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtFindAuthorName;
        private System.Windows.Forms.Button btnFindAuthors;
        private System.Windows.Forms.Button btnTransform;
    }
}

