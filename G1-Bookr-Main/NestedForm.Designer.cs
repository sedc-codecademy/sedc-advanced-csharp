namespace G1_Bookr_Main
{
    partial class NestedForm
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
            this.lstNovels = new System.Windows.Forms.ListBox();
            this.lstAuthors = new System.Windows.Forms.ListBox();
            this.txtNovelTitle = new System.Windows.Forms.TextBox();
            this.btnSaveNovel = new System.Windows.Forms.Button();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.btnSaveAuthor = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNovels
            // 
            this.lstNovels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstNovels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNovels.FormattingEnabled = true;
            this.lstNovels.ItemHeight = 25;
            this.lstNovels.Location = new System.Drawing.Point(320, 7);
            this.lstNovels.Margin = new System.Windows.Forms.Padding(6);
            this.lstNovels.Name = "lstNovels";
            this.lstNovels.Size = new System.Drawing.Size(325, 554);
            this.lstNovels.TabIndex = 7;
            // 
            // lstAuthors
            // 
            this.lstAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAuthors.FormattingEnabled = true;
            this.lstAuthors.ItemHeight = 25;
            this.lstAuthors.Location = new System.Drawing.Point(15, 4);
            this.lstAuthors.Margin = new System.Windows.Forms.Padding(6);
            this.lstAuthors.Name = "lstAuthors";
            this.lstAuthors.Size = new System.Drawing.Size(302, 554);
            this.lstAuthors.TabIndex = 6;
            this.lstAuthors.SelectedIndexChanged += new System.EventHandler(this.lstAuthors_SelectedIndexChanged);
            // 
            // txtNovelTitle
            // 
            this.txtNovelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovelTitle.Location = new System.Drawing.Point(666, 89);
            this.txtNovelTitle.Name = "txtNovelTitle";
            this.txtNovelTitle.Size = new System.Drawing.Size(177, 31);
            this.txtNovelTitle.TabIndex = 14;
            // 
            // btnSaveNovel
            // 
            this.btnSaveNovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNovel.Location = new System.Drawing.Point(849, 89);
            this.btnSaveNovel.Name = "btnSaveNovel";
            this.btnSaveNovel.Size = new System.Drawing.Size(149, 31);
            this.btnSaveNovel.TabIndex = 13;
            this.btnSaveNovel.Text = "Save Novel";
            this.btnSaveNovel.UseVisualStyleBackColor = true;
            this.btnSaveNovel.Click += new System.EventHandler(this.btnSaveNovel_Click);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(666, 28);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(177, 31);
            this.txtAuthorName.TabIndex = 12;
            // 
            // btnSaveAuthor
            // 
            this.btnSaveAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAuthor.Location = new System.Drawing.Point(849, 28);
            this.btnSaveAuthor.Name = "btnSaveAuthor";
            this.btnSaveAuthor.Size = new System.Drawing.Size(149, 31);
            this.btnSaveAuthor.TabIndex = 11;
            this.btnSaveAuthor.Text = "Save Author";
            this.btnSaveAuthor.UseVisualStyleBackColor = true;
            this.btnSaveAuthor.Click += new System.EventHandler(this.btnSaveAuthor_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransform.Location = new System.Drawing.Point(693, 221);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(332, 63);
            this.btnTransform.TabIndex = 15;
            this.btnTransform.Text = "Transform Data The Other Way";
            this.btnTransform.UseVisualStyleBackColor = true;
            // 
            // NestedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 597);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.txtNovelTitle);
            this.Controls.Add(this.btnSaveNovel);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.btnSaveAuthor);
            this.Controls.Add(this.lstNovels);
            this.Controls.Add(this.lstAuthors);
            this.Name = "NestedForm";
            this.Text = "NestedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNovels;
        private System.Windows.Forms.ListBox lstAuthors;
        private System.Windows.Forms.TextBox txtNovelTitle;
        private System.Windows.Forms.Button btnSaveNovel;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Button btnSaveAuthor;
        private System.Windows.Forms.Button btnTransform;
    }
}