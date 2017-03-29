namespace G3_Bookr_Main
{
    partial class NestedAuthors
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
            this.btnWarPeace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNovels
            // 
            this.lstNovels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstNovels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNovels.FormattingEnabled = true;
            this.lstNovels.ItemHeight = 25;
            this.lstNovels.Location = new System.Drawing.Point(300, 15);
            this.lstNovels.Margin = new System.Windows.Forms.Padding(6);
            this.lstNovels.Name = "lstNovels";
            this.lstNovels.Size = new System.Drawing.Size(292, 429);
            this.lstNovels.TabIndex = 4;
            // 
            // lstAuthors
            // 
            this.lstAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAuthors.FormattingEnabled = true;
            this.lstAuthors.ItemHeight = 25;
            this.lstAuthors.Location = new System.Drawing.Point(6, 15);
            this.lstAuthors.Margin = new System.Windows.Forms.Padding(6);
            this.lstAuthors.Name = "lstAuthors";
            this.lstAuthors.Size = new System.Drawing.Size(270, 429);
            this.lstAuthors.TabIndex = 3;
            this.lstAuthors.SelectedIndexChanged += new System.EventHandler(this.lstAuthors_SelectedIndexChanged);
            // 
            // btnWarPeace
            // 
            this.btnWarPeace.Location = new System.Drawing.Point(693, 59);
            this.btnWarPeace.Name = "btnWarPeace";
            this.btnWarPeace.Size = new System.Drawing.Size(214, 97);
            this.btnWarPeace.TabIndex = 5;
            this.btnWarPeace.Text = "Add War and Peace";
            this.btnWarPeace.UseVisualStyleBackColor = true;
            this.btnWarPeace.Click += new System.EventHandler(this.btnWarPeace_Click);
            // 
            // NestedAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 587);
            this.Controls.Add(this.btnWarPeace);
            this.Controls.Add(this.lstNovels);
            this.Controls.Add(this.lstAuthors);
            this.Name = "NestedAuthors";
            this.Text = "NestedAuthors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNovels;
        private System.Windows.Forms.ListBox lstAuthors;
        private System.Windows.Forms.Button btnWarPeace;
    }
}