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
            this.FirstNameInsertText = new System.Windows.Forms.TextBox();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandomMovieListBox
            // 
            this.RandomMovieListBox.FormattingEnabled = true;
            this.RandomMovieListBox.ItemHeight = 20;
            this.RandomMovieListBox.Location = new System.Drawing.Point(425, 85);
            this.RandomMovieListBox.Name = "RandomMovieListBox";
            this.RandomMovieListBox.Size = new System.Drawing.Size(384, 44);
            this.RandomMovieListBox.TabIndex = 0;
            this.RandomMovieListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(547, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(143, 28);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Pick Movie";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MovieNameInsertLabel
            // 
            this.MovieNameInsertLabel.AutoSize = true;
            this.MovieNameInsertLabel.Location = new System.Drawing.Point(824, 567);
            this.MovieNameInsertLabel.Name = "MovieNameInsertLabel";
            this.MovieNameInsertLabel.Size = new System.Drawing.Size(100, 20);
            this.MovieNameInsertLabel.TabIndex = 5;
            this.MovieNameInsertLabel.Text = "Movie Name:";
            this.MovieNameInsertLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FirstNameInsertText
            // 
            this.FirstNameInsertText.Location = new System.Drawing.Point(930, 564);
            this.FirstNameInsertText.Name = "FirstNameInsertText";
            this.FirstNameInsertText.Size = new System.Drawing.Size(113, 26);
            this.FirstNameInsertText.TabIndex = 4;
            this.FirstNameInsertText.TextChanged += new System.EventHandler(this.FirstNameInsertText_TextChanged);
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(886, 596);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(75, 28);
            this.InsertRecordButton.TabIndex = 12;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.MovieNameInsertLabel);
            this.Controls.Add(this.FirstNameInsertText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RandomMovieListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RandomMovieListBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label MovieNameInsertLabel;
        private System.Windows.Forms.TextBox FirstNameInsertText;
        private System.Windows.Forms.Button InsertRecordButton;
    }
}

