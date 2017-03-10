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

namespace JekyllPost
{
    public partial class JekyllPost : Form
    {
        public JekyllPost()
        {
            InitializeComponent();
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
                
                MessageBox.Show("Post has been successfully written.");

                
            }
            else
            {
                MessageBox.Show("ERROR: Please enter all required fields!\n\nRequired fields are marked with (*).");
            }

            

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + @"_posts\");
            var files = new List<string> {};
            files.AddRange(di.GetFiles().Select(file => file.Name));

            postListBox.DataSource = files;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var postFilePath = AppDomain.CurrentDomain.BaseDirectory + @"_posts\" + postListBox.SelectedItem.ToString();
            var sr = new StreamReader(postFilePath);
            var line = new List<string> {};
            while (sr.ReadLine() != null)
            {
                line.Add(sr.ReadLine());
            }

            line.AddRange();

            this.titleTextBox.Text
        }
    }

}
   