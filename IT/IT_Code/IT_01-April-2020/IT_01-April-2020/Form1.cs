using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace IT_01_April_2020
{
    public partial class Form1 : Form
    {
        string fileName = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\test1.txt";
        string newLocation = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + @"\SpecialFolder\test1.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadWholeFileButton_Click(object sender, EventArgs e)
        {
            if (FileExist(fileName))
            {
                using (var reader = new StreamReader(fileName, Encoding.UTF8))
                {
                    textBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void ReadFileLBLButton_Click(object sender, EventArgs e)
        {
            if (FileExist(fileName))
            {
                textBox1.Clear();
                using (var reader = new StreamReader(fileName, Encoding.UTF8))
                {
                    string textLine;
                    while ((textLine = reader.ReadLine()) != null)
                    {
                        textBox1.Text += textLine + Environment.NewLine;
                    }
                }
            }
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            openFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            if (openFD.ShowDialog() != DialogResult.Cancel)
            {
                fileName = openFD.FileName;
            }
        }

        private void writeFileButton_Click(object sender, EventArgs e)
        {
            string outputText = textBox2.Text;

            outputText = textBox2.Text.Length <= 0 ? string.Empty : $"{textBox2.Text} {Environment.NewLine}{new string('-', 15)}{Environment.NewLine}";
            var array = new string[]
            {
                "Marry",
                "had",
                "a",
                "little",
                "lamb"
            };

            outputText += string.Join(Environment.NewLine, array);

            using (var writer = new StreamWriter(fileName, true, Encoding.UTF8))
            {
                writer.WriteLine(outputText);
            }

            MessageBox.Show("File saved!");
            textBox2.Clear();
            textBox2.Text = outputText;
        }

        private bool FileExist(string fileDir)
        {
            if (File.Exists(fileDir))
            {
                return true;
            }
            MessageBox.Show($"{fileDir} does not exist!");
            return false;
        }

        private void chooseNewLocationButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    newLocation = folderDialog.SelectedPath;
                    newLocation += fileName.Substring(fileName.LastIndexOf('\\'));
                }
            }
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            if (FileExist(fileName))
            {
                File.Delete(fileName);
                MessageBox.Show("File deleted!");
            }
        }

        private void moveFileButton_Click(object sender, EventArgs e)
        {
            if (FileExist(fileName))
            {
                File.Move(fileName, newLocation);
                MessageBox.Show("File moved!");
            }
        }

        private void copyFileButton_Click(object sender, EventArgs e)
        {
            if (FileExist(fileName))
            {
                File.Copy(fileName, newLocation, true);
                MessageBox.Show("File copied!");
            }
        }
    }
}
