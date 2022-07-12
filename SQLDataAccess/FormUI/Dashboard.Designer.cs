namespace FormUI
{
    partial class Dashboard
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
            this.RandomMovieListBox = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MovieNameInsertLabel = new System.Windows.Forms.Label();
            this.MovieNameInsertText = new System.Windows.Forms.TextBox();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandomMovieListBox
            // 
            this.RandomMovieListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.RandomMovieListBox.FormattingEnabled = true;
            this.RandomMovieListBox.ItemHeight = 46;
            this.RandomMovieListBox.Location = new System.Drawing.Point(237, 75);
            this.RandomMovieListBox.Name = "RandomMovieListBox";
            this.RandomMovieListBox.Size = new System.Drawing.Size(410, 50);
            this.RandomMovieListBox.TabIndex = 0;
            this.RandomMovieListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SearchButton.Location = new System.Drawing.Point(394, 28);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(171, 41);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Pick Movie";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MovieNameInsertLabel
            // 
            this.MovieNameInsertLabel.AutoSize = true;
            this.MovieNameInsertLabel.Location = new System.Drawing.Point(674, 386);
            this.MovieNameInsertLabel.Name = "MovieNameInsertLabel";
            this.MovieNameInsertLabel.Size = new System.Drawing.Size(100, 20);
            this.MovieNameInsertLabel.TabIndex = 5;
            this.MovieNameInsertLabel.Text = "Movie Name:";
            this.MovieNameInsertLabel.Click += new System.EventHandler(this.InsertLabelClick);
            // 
            // MovieNameInsertText
            // 
            this.MovieNameInsertText.Location = new System.Drawing.Point(780, 383);
            this.MovieNameInsertText.Name = "MovieNameInsertText";
            this.MovieNameInsertText.Size = new System.Drawing.Size(113, 26);
            this.MovieNameInsertText.TabIndex = 4;
            this.MovieNameInsertText.TextChanged += new System.EventHandler(this.MovieNameInsertText_TextChanged);
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.InsertRecordButton.Location = new System.Drawing.Point(736, 415);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(75, 28);
            this.InsertRecordButton.TabIndex = 12;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = false;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertMovieButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RemoveButton.Location = new System.Drawing.Point(653, 75);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(130, 50);
            this.RemoveButton.TabIndex = 13;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 20;
            this.MoviesListBox.Location = new System.Drawing.Point(27, 257);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(288, 204);
            this.MoviesListBox.TabIndex = 14;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ShowAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ShowAllButton.Location = new System.Drawing.Point(79, 210);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(171, 41);
            this.ShowAllButton.TabIndex = 15;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = false;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 480);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.MoviesListBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.MovieNameInsertLabel);
            this.Controls.Add(this.MovieNameInsertText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RandomMovieListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "Movie Night";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RandomMovieListBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label MovieNameInsertLabel;
        private System.Windows.Forms.TextBox MovieNameInsertText;
        private System.Windows.Forms.Button InsertRecordButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Button ShowAllButton;
    }
}

