using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace JekyllPost
{
    public partial class JekyllPost : Form
    {
        public JekyllPost()
        {
            InitializeComponent();

            RefreshListBox();
        }

        private string fileName;
        private string filePath;

        private List<string> formatedText;



        private void postButton_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(this.titleTextBox.Text) && !String.IsNullOrWhiteSpace(this.dateTimePicker1.Value.ToString("yyyy-MM-dd")) && !String.IsNullOrWhiteSpace(this.contentTextBox.Text))
            {
                fileName = this.dateTimePicker1.Value.ToString("yyyy-MM-dd") + '-' + this.titleTextBox.Text.ToLower().Replace(' ', '-').Replace("/", "-");
                filePath = AppDomain.CurrentDomain.BaseDirectory + @"_posts\" + fileName + ".markdown";

                formatedText = new List<string>
                {
                "---",
                "title: " + this.titleTextBox.Text,
                "date: " + this.dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                "categories: " + this.categoriesTextBox.Text.ToLower().Trim(),
                "layout: post",
                "---",
                this.contentTextBox.Text
                };

                using (var fs = new StreamWriter(filePath))
                {
                    foreach (var item in formatedText)
                    {
                        fs.WriteLine(item);
                    }
                }
                this.titleTextBox.Text = "";
                this.categoriesTextBox.Text = "";
                this.contentTextBox.Text = "";

                RefreshListBox();

                MessageBox.Show("Post has been successfully written.");

                
            }
            else
            {
                MessageBox.Show("ERROR: Please enter all required fields!\n\nRequired fields are marked with (*).");
            }

            

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshListBox();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (postListBox.SelectedItem == null)
            {
                MessageBox.Show("Select post to edit!");
            }
            else
            {
                var postFilePath = AppDomain.CurrentDomain.BaseDirectory + @"_posts\" +
                                   postListBox.SelectedItem.ToString();
                var title = File.ReadLines(postFilePath).ElementAt(1);
                var date = File.ReadLines(postFilePath).ElementAt(2);
                var categories = File.ReadLines(postFilePath).ElementAt(3);
                var description = File.ReadLines(postFilePath).Skip(6);


                this.titleTextBox.Text = title != null ? title.Replace("title: ", string.Empty) : "";
                this.dateTimePicker1.Value = date != null
                    ? Convert.ToDateTime(date.Replace("date: ", string.Empty))
                    : DateTime.Today;
                this.categoriesTextBox.Text = categories != null ? categories.Replace("categories: ", string.Empty) : "";
                this.contentTextBox.Text = string.Join("\n", description) != null ? string.Join("\n", description) : "";
            }
        }


        private void RefreshListBox()
        {
            var di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"_posts\");
            var files = new List<string> { };
            files.AddRange(di.GetFiles().Select(file => file.Name));

            postListBox.DataSource = files;
        }
    }

}
   