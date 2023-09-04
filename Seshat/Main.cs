using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seshat
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private void DestinationtextBox_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            String result = dialog.SelectedPath;
            DestinationtextBox.Text = result.ToString();
        }

        private void DestinationtextBox2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            String result = dialog.SelectedPath;
            DestinationtextBox2.Text = result.ToString();
        }

        private void DestinationtextBox3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            String result = dialog.SelectedPath;
            DestinationtextBox3.Text = result.ToString();
        }

        private void DestinationtextBox4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            String result = dialog.SelectedPath;
            DestinationtextBox4.Text = result.ToString();
        }

        private void DestinationtextBox5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            String result = dialog.SelectedPath;
            DestinationtextBox5.Text = result.ToString();
        }

        private void DestinationtextBox6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            String result = dialog.SelectedPath;
            DestinationtextBox6.Text = result.ToString();
        }
        private void SourcetextBox_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            String result = dialog.SelectedPath;
            SourcetextBox.Text = result.ToString();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string sourceDirectory = SourcetextBox.Text.Trim();

            TextBox[] extensionTextBoxes = { ExtensiontextBox, ExtensiontextBox2, ExtensiontextBox3, ExtensiontextBox4, ExtensiontextBox5, ExtensiontextBox6 };
            TextBox[] destinationTextBoxes = { DestinationtextBox, DestinationtextBox2, DestinationtextBox3, DestinationtextBox4, DestinationtextBox5, DestinationtextBox6 };

            Dictionary<string, string> result = extentionDictionary(extensionTextBoxes, destinationTextBoxes);


            if (Directory.Exists(sourceDirectory))
            {
                foreach (var kvp in result)
                {
                    string extension = kvp.Key;
                    string destinationDirectory = kvp.Value;

                    string[] files = Directory.GetFiles(sourceDirectory, $"*.{extension}");

                    foreach (string filePath in files)
                    {
                        string fileName = Path.GetFileName(filePath);
                        string targetFilePath = Path.Combine(destinationDirectory, fileName);
                        File.Move(filePath, targetFilePath);
                    }
                }

                MessageBox.Show("File sorting completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Source directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Dictionary<string, string> extentionDictionary(TextBox[] extensionTextBoxes, TextBox[] destinationTextBoxes)
        {
            Dictionary<string, string> extensionToDirectory = new Dictionary<string, string>();

            for (int i = 0; i < extensionTextBoxes.Length; i++)
            {
                string extension = extensionTextBoxes[i].Text.Trim();
                string destination = destinationTextBoxes[i].Text.Trim();

                if (!string.IsNullOrEmpty(extension) && !string.IsNullOrEmpty(destination))
                {
                    extensionToDirectory.Add(extension, destination);
                }
            }

            return extensionToDirectory;
        }

        private void PlaypictureBox1_Click(object sender, EventArgs e)
        {
            string sourceDirectory = SourcetextBox.Text.Trim();
            
            if (Directory.Exists(sourceDirectory))
            {
                string[] files = Directory.GetFiles(sourceDirectory, $"*.{ExtensiontextBox.Text}");
                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileName(filePath);
                    string targetFilePath = Path.Combine(DestinationtextBox.Text, fileName);
                    File.Move(filePath, targetFilePath);
                }
                MessageBox.Show("File sorting completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Source directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        

       
        private void PlaypictureBox2_Click(object sender, EventArgs e)
        {
            string sourceDirectory = SourcetextBox.Text.Trim();

            if (Directory.Exists(sourceDirectory))
            {
                string[] files = Directory.GetFiles(sourceDirectory, $"*.{ExtensiontextBox2.Text}");
                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileName(filePath);
                    string targetFilePath = Path.Combine(DestinationtextBox2.Text, fileName);
                    File.Move(filePath, targetFilePath);
                }
                MessageBox.Show("File sorting completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Source directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaypictureBox3_Click(object sender, EventArgs e)
        {
            string sourceDirectory = SourcetextBox.Text.Trim();

            if (Directory.Exists(sourceDirectory))
            {
                string[] files = Directory.GetFiles(sourceDirectory, $"*.{ExtensiontextBox3.Text}");
                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileName(filePath);
                    string targetFilePath = Path.Combine(DestinationtextBox3.Text, fileName);
                    File.Move(filePath, targetFilePath);
                }
                MessageBox.Show("File sorting completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Source directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaypictureBox4_Click(object sender, EventArgs e)
        {
            string sourceDirectory = SourcetextBox.Text.Trim();

            if (Directory.Exists(sourceDirectory))
            {
                string[] files = Directory.GetFiles(sourceDirectory, $"*.{ExtensiontextBox4.Text}");
                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileName(filePath);
                    string targetFilePath = Path.Combine(DestinationtextBox4.Text, fileName);
                    File.Move(filePath, targetFilePath);
                }
                MessageBox.Show("File sorting completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Source directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaypictureBox5_Click(object sender, EventArgs e)
        {
            string sourceDirectory = SourcetextBox.Text.Trim();

            if (Directory.Exists(sourceDirectory))
            {
                string[] files = Directory.GetFiles(sourceDirectory, $"*.{ExtensiontextBox5.Text}");
                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileName(filePath);
                    string targetFilePath = Path.Combine(DestinationtextBox5.Text, fileName);
                    File.Move(filePath, targetFilePath);
                }
                MessageBox.Show("File sorting completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Source directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaypictureBox6_Click(object sender, EventArgs e)
        {
            string sourceDirectory = SourcetextBox.Text.Trim();

            if (Directory.Exists(sourceDirectory))
            {
                string[] files = Directory.GetFiles(sourceDirectory, $"*.{ExtensiontextBox6.Text}");
                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileName(filePath);
                    string targetFilePath = Path.Combine(DestinationtextBox6.Text, fileName);
                    File.Move(filePath, targetFilePath);
                }
                MessageBox.Show("File sorting completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Source directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TrashpictureBox1_Click(object sender, EventArgs e)
        {
            ExtensiontextBox.Text = string.Empty;
            DestinationtextBox.Text = string.Empty; 
        }

        private void TrashpictureBox2_Click(object sender, EventArgs e)
        {
            ExtensiontextBox2.Text = string.Empty;
            DestinationtextBox2.Text = string.Empty;
        }

        private void TrashpictureBox3_Click(object sender, EventArgs e)
        {
            ExtensiontextBox3.Text = string.Empty;
            DestinationtextBox3.Text = string.Empty;
        }

        private void TrashpictureBox4_Click(object sender, EventArgs e)
        {
            ExtensiontextBox4.Text = string.Empty;
            DestinationtextBox4.Text = string.Empty;
        }

        private void TrashpictureBox5_Click(object sender, EventArgs e)
        {
            ExtensiontextBox5.Text = string.Empty;
            DestinationtextBox5.Text = string.Empty;
        }

        private void TrashpictureBox6_Click(object sender, EventArgs e)
        {
            ExtensiontextBox6.Text = string.Empty;
            DestinationtextBox6.Text = string.Empty;
        }
    }
}




