namespace WalkThroughHashTableApp
{
    partial class WalkThroughWithHashTableUI
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
            this.addIsbnTextBox = new System.Windows.Forms.TextBox();
            this.addBookDetailsTextBox = new System.Windows.Forms.TextBox();
            this.addIsbnLabel = new System.Windows.Forms.Label();
            this.addBookDetaillsLabel = new System.Windows.Forms.Label();
            this.addBookInfoLabel = new System.Windows.Forms.Label();
            this.searchIsbnTextBox = new System.Windows.Forms.TextBox();
            this.searchBookDetailTextBox = new System.Windows.Forms.TextBox();
            this.searchIsbnLabel = new System.Windows.Forms.Label();
            this.searchBookDetailsLabel = new System.Windows.Forms.Label();
            this.searchBookLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addIsbnTextBox
            // 
            this.addIsbnTextBox.Location = new System.Drawing.Point(228, 57);
            this.addIsbnTextBox.Name = "addIsbnTextBox";
            this.addIsbnTextBox.Size = new System.Drawing.Size(270, 20);
            this.addIsbnTextBox.TabIndex = 0;
            // 
            // addBookDetailsTextBox
            // 
            this.addBookDetailsTextBox.Location = new System.Drawing.Point(228, 83);
            this.addBookDetailsTextBox.Multiline = true;
            this.addBookDetailsTextBox.Name = "addBookDetailsTextBox";
            this.addBookDetailsTextBox.Size = new System.Drawing.Size(270, 71);
            this.addBookDetailsTextBox.TabIndex = 1;
            // 
            // addIsbnLabel
            // 
            this.addIsbnLabel.AutoSize = true;
            this.addIsbnLabel.Location = new System.Drawing.Point(179, 64);
            this.addIsbnLabel.Name = "addIsbnLabel";
            this.addIsbnLabel.Size = new System.Drawing.Size(32, 13);
            this.addIsbnLabel.TabIndex = 2;
            this.addIsbnLabel.Text = "ISBN";
            // 
            // addBookDetaillsLabel
            // 
            this.addBookDetaillsLabel.AutoSize = true;
            this.addBookDetaillsLabel.Location = new System.Drawing.Point(144, 86);
            this.addBookDetaillsLabel.Name = "addBookDetaillsLabel";
            this.addBookDetaillsLabel.Size = new System.Drawing.Size(67, 13);
            this.addBookDetaillsLabel.TabIndex = 3;
            this.addBookDetaillsLabel.Text = "Book Details";
            // 
            // addBookInfoLabel
            // 
            this.addBookInfoLabel.AutoSize = true;
            this.addBookInfoLabel.Location = new System.Drawing.Point(101, 34);
            this.addBookInfoLabel.Name = "addBookInfoLabel";
            this.addBookInfoLabel.Size = new System.Drawing.Size(75, 13);
            this.addBookInfoLabel.TabIndex = 4;
            this.addBookInfoLabel.Text = "Add Book Info";
            // 
            // searchIsbnTextBox
            // 
            this.searchIsbnTextBox.Location = new System.Drawing.Point(228, 193);
            this.searchIsbnTextBox.Name = "searchIsbnTextBox";
            this.searchIsbnTextBox.Size = new System.Drawing.Size(270, 20);
            this.searchIsbnTextBox.TabIndex = 5;
            // 
            // searchBookDetailTextBox
            // 
            this.searchBookDetailTextBox.Location = new System.Drawing.Point(228, 219);
            this.searchBookDetailTextBox.Multiline = true;
            this.searchBookDetailTextBox.Name = "searchBookDetailTextBox";
            this.searchBookDetailTextBox.Size = new System.Drawing.Size(270, 83);
            this.searchBookDetailTextBox.TabIndex = 6;
            // 
            // searchIsbnLabel
            // 
            this.searchIsbnLabel.AutoSize = true;
            this.searchIsbnLabel.Location = new System.Drawing.Point(176, 193);
            this.searchIsbnLabel.Name = "searchIsbnLabel";
            this.searchIsbnLabel.Size = new System.Drawing.Size(32, 13);
            this.searchIsbnLabel.TabIndex = 7;
            this.searchIsbnLabel.Text = "ISBN";
            // 
            // searchBookDetailsLabel
            // 
            this.searchBookDetailsLabel.AutoSize = true;
            this.searchBookDetailsLabel.Location = new System.Drawing.Point(144, 222);
            this.searchBookDetailsLabel.Name = "searchBookDetailsLabel";
            this.searchBookDetailsLabel.Size = new System.Drawing.Size(67, 13);
            this.searchBookDetailsLabel.TabIndex = 8;
            this.searchBookDetailsLabel.Text = "Book Details";
            // 
            // searchBookLabel
            // 
            this.searchBookLabel.AutoSize = true;
            this.searchBookLabel.Location = new System.Drawing.Point(101, 175);
            this.searchBookLabel.Name = "searchBookLabel";
            this.searchBookLabel.Size = new System.Drawing.Size(66, 13);
            this.searchBookLabel.TabIndex = 9;
            this.searchBookLabel.Text = "Seach Book";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(504, 131);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(504, 279);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 11;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // WalkThroughWithHashTableUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 376);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchBookLabel);
            this.Controls.Add(this.searchBookDetailsLabel);
            this.Controls.Add(this.searchIsbnLabel);
            this.Controls.Add(this.searchBookDetailTextBox);
            this.Controls.Add(this.searchIsbnTextBox);
            this.Controls.Add(this.addBookInfoLabel);
            this.Controls.Add(this.addBookDetaillsLabel);
            this.Controls.Add(this.addIsbnLabel);
            this.Controls.Add(this.addBookDetailsTextBox);
            this.Controls.Add(this.addIsbnTextBox);
            this.Name = "WalkThroughWithHashTableUI";
            this.Text = "Walk Through With Hash table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addIsbnTextBox;
        private System.Windows.Forms.TextBox addBookDetailsTextBox;
        private System.Windows.Forms.Label addIsbnLabel;
        private System.Windows.Forms.Label addBookDetaillsLabel;
        private System.Windows.Forms.Label addBookInfoLabel;
        private System.Windows.Forms.TextBox searchIsbnTextBox;
        private System.Windows.Forms.TextBox searchBookDetailTextBox;
        private System.Windows.Forms.Label searchIsbnLabel;
        private System.Windows.Forms.Label searchBookDetailsLabel;
        private System.Windows.Forms.Label searchBookLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button findButton;





    }
}

