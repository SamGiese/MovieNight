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
            this.PeopleFoundListBox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FirstNameInsertLabel = new System.Windows.Forms.Label();
            this.FirstNameInsertText = new System.Windows.Forms.TextBox();
            this.LastNameInsertLabel = new System.Windows.Forms.Label();
            this.LastNameInsertText = new System.Windows.Forms.TextBox();
            this.BusinessEntityIDInsertLabel = new System.Windows.Forms.Label();
            this.BusinessEntityIDInsertText = new System.Windows.Forms.TextBox();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.PersonTypeInsertLabel = new System.Windows.Forms.Label();
            this.PersonTypeInsertText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PeopleFoundListBox
            // 
            this.PeopleFoundListBox.FormattingEnabled = true;
            this.PeopleFoundListBox.ItemHeight = 20;
            this.PeopleFoundListBox.Location = new System.Drawing.Point(12, 91);
            this.PeopleFoundListBox.Name = "PeopleFoundListBox";
            this.PeopleFoundListBox.Size = new System.Drawing.Size(316, 204);
            this.PeopleFoundListBox.TabIndex = 0;
            this.PeopleFoundListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(110, 12);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(100, 26);
            this.LastNameText.TabIndex = 1;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(18, 15);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(110, 44);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 28);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FirstNameInsertLabel
            // 
            this.FirstNameInsertLabel.AutoSize = true;
            this.FirstNameInsertLabel.Location = new System.Drawing.Point(694, 18);
            this.FirstNameInsertLabel.Name = "FirstNameInsertLabel";
            this.FirstNameInsertLabel.Size = new System.Drawing.Size(86, 20);
            this.FirstNameInsertLabel.TabIndex = 5;
            this.FirstNameInsertLabel.Text = "First Name";
            this.FirstNameInsertLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FirstNameInsertText
            // 
            this.FirstNameInsertText.Location = new System.Drawing.Point(840, 15);
            this.FirstNameInsertText.Name = "FirstNameInsertText";
            this.FirstNameInsertText.Size = new System.Drawing.Size(113, 26);
            this.FirstNameInsertText.TabIndex = 4;
            // 
            // LastNameInsertLabel
            // 
            this.LastNameInsertLabel.AutoSize = true;
            this.LastNameInsertLabel.Location = new System.Drawing.Point(694, 50);
            this.LastNameInsertLabel.Name = "LastNameInsertLabel";
            this.LastNameInsertLabel.Size = new System.Drawing.Size(86, 20);
            this.LastNameInsertLabel.TabIndex = 7;
            this.LastNameInsertLabel.Text = "Last Name";
            // 
            // LastNameInsertText
            // 
            this.LastNameInsertText.Location = new System.Drawing.Point(840, 47);
            this.LastNameInsertText.Name = "LastNameInsertText";
            this.LastNameInsertText.Size = new System.Drawing.Size(113, 26);
            this.LastNameInsertText.TabIndex = 6;
            // 
            // BusinessEntityIDInsertLabel
            // 
            this.BusinessEntityIDInsertLabel.AutoSize = true;
            this.BusinessEntityIDInsertLabel.Location = new System.Drawing.Point(694, 127);
            this.BusinessEntityIDInsertLabel.Name = "BusinessEntityIDInsertLabel";
            this.BusinessEntityIDInsertLabel.Size = new System.Drawing.Size(139, 20);
            this.BusinessEntityIDInsertLabel.TabIndex = 11;
            this.BusinessEntityIDInsertLabel.Text = "Business Entity ID";
            // 
            // BusinessEntityIDInsertText
            // 
            this.BusinessEntityIDInsertText.Location = new System.Drawing.Point(840, 124);
            this.BusinessEntityIDInsertText.Name = "BusinessEntityIDInsertText";
            this.BusinessEntityIDInsertText.Size = new System.Drawing.Size(113, 26);
            this.BusinessEntityIDInsertText.TabIndex = 10;
            this.BusinessEntityIDInsertText.TextChanged += new System.EventHandler(this.BusinessEntityIDInsertText_TextChanged);
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(786, 156);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(75, 28);
            this.InsertRecordButton.TabIndex = 12;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // PersonTypeInsertLabel
            // 
            this.PersonTypeInsertLabel.AutoSize = true;
            this.PersonTypeInsertLabel.Location = new System.Drawing.Point(694, 82);
            this.PersonTypeInsertLabel.Name = "PersonTypeInsertLabel";
            this.PersonTypeInsertLabel.Size = new System.Drawing.Size(97, 20);
            this.PersonTypeInsertLabel.TabIndex = 14;
            this.PersonTypeInsertLabel.Text = "Person Type";
            // 
            // PersonTypeInsertText
            // 
            this.PersonTypeInsertText.Location = new System.Drawing.Point(840, 79);
            this.PersonTypeInsertText.Name = "PersonTypeInsertText";
            this.PersonTypeInsertText.Size = new System.Drawing.Size(113, 26);
            this.PersonTypeInsertText.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.PersonTypeInsertLabel);
            this.Controls.Add(this.PersonTypeInsertText);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.BusinessEntityIDInsertLabel);
            this.Controls.Add(this.BusinessEntityIDInsertText);
            this.Controls.Add(this.LastNameInsertLabel);
            this.Controls.Add(this.LastNameInsertText);
            this.Controls.Add(this.FirstNameInsertLabel);
            this.Controls.Add(this.FirstNameInsertText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.PeopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleFoundListBox;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label FirstNameInsertLabel;
        private System.Windows.Forms.TextBox FirstNameInsertText;
        private System.Windows.Forms.Label LastNameInsertLabel;
        private System.Windows.Forms.TextBox LastNameInsertText;
        private System.Windows.Forms.Label BusinessEntityIDInsertLabel;
        private System.Windows.Forms.TextBox BusinessEntityIDInsertText;
        private System.Windows.Forms.Button InsertRecordButton;
        private System.Windows.Forms.Label PersonTypeInsertLabel;
        private System.Windows.Forms.TextBox PersonTypeInsertText;
    }
}

