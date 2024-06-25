namespace DictionaryApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox termNameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox termDescriptionTextBox;
        private System.Windows.Forms.Button addTermButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label letterLabel;
        private System.Windows.Forms.TextBox letterTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ListBox resultListBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.termNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.termDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addTermButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.letterLabel = new System.Windows.Forms.Label();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Назва терміну:";
            // 
            // termNameTextBox
            // 
            this.termNameTextBox.Location = new System.Drawing.Point(100, 10);
            this.termNameTextBox.Name = "termNameTextBox";
            this.termNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.termNameTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(10, 40);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Опис:";
            // 
            // termDescriptionTextBox
            // 
            this.termDescriptionTextBox.Location = new System.Drawing.Point(100, 40);
            this.termDescriptionTextBox.Name = "termDescriptionTextBox";
            this.termDescriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.termDescriptionTextBox.TabIndex = 3;
            // 
            // addTermButton
            // 
            this.addTermButton.Location = new System.Drawing.Point(100, 70);
            this.addTermButton.Name = "addTermButton";
            this.addTermButton.Size = new System.Drawing.Size(100, 23);
            this.addTermButton.TabIndex = 4;
            this.addTermButton.Text = "Додати термін";
            this.addTermButton.UseVisualStyleBackColor = true;
            this.addTermButton.Click += new System.EventHandler(this.AddTermButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(10, 100);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(68, 13);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Знайти термін:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(100, 100);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 20);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(100, 130);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // letterLabel
            // 
            this.letterLabel.AutoSize = true;
            this.letterLabel.Location = new System.Drawing.Point(10, 160);
            this.letterLabel.Name = "letterLabel";
            this.letterLabel.Size = new System.Drawing.Size(77, 13);
            this.letterLabel.TabIndex = 8;
            this.letterLabel.Text = "Початкова буква:";
            // 
            // letterTextBox
            // 
            this.letterTextBox.Location = new System.Drawing.Point(100, 160);
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(50, 20);
            this.letterTextBox.TabIndex = 9;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(100, 190);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(100, 23);
            this.displayButton.TabIndex = 10;
            this.displayButton.Text = "Вивести";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(10, 220);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(290, 200);
            this.resultListBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.termNameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.termDescriptionTextBox);
            this.Controls.Add(this.addTermButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.letterLabel);
            this.Controls.Add(this.letterTextBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.resultListBox);
            this.Name = "Form1";
            this.Text = "Програма 'Словник'";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
