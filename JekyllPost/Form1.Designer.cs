namespace JekyllPost
{
    partial class JekyllPost
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.categoriesTextBox = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.postListBox = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(49, 16);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:*";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(15, 28);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(561, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // postButton
            // 
            this.postButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postButton.Location = new System.Drawing.Point(212, 534);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(166, 39);
            this.postButton.TabIndex = 2;
            this.postButton.Text = "POST";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(12, 62);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(51, 16);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date:*";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesLabel.Location = new System.Drawing.Point(12, 120);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(88, 16);
            this.categoriesLabel.TabIndex = 5;
            this.categoriesLabel.Text = "Categories:";
            // 
            // categoriesTextBox
            // 
            this.categoriesTextBox.Location = new System.Drawing.Point(15, 139);
            this.categoriesTextBox.Name = "categoriesTextBox";
            this.categoriesTextBox.Size = new System.Drawing.Size(561, 20);
            this.categoriesTextBox.TabIndex = 6;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLabel.Location = new System.Drawing.Point(12, 180);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(70, 16);
            this.contentLabel.TabIndex = 7;
            this.contentLabel.Text = "Content:*";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(15, 199);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(560, 315);
            this.contentTextBox.TabIndex = 8;
            // 
            // postListBox
            // 
            this.postListBox.FormattingEnabled = true;
            this.postListBox.Location = new System.Drawing.Point(627, 30);
            this.postListBox.Name = "postListBox";
            this.postListBox.Size = new System.Drawing.Size(428, 485);
            this.postListBox.TabIndex = 9;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(627, 534);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(166, 39);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(889, 534);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(166, 39);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // JekyllPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 587);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.postListBox);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.categoriesTextBox);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "JekyllPost";
            this.Text = "JekyllPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.TextBox categoriesTextBox;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.ListBox postListBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button editButton;
    }
}

