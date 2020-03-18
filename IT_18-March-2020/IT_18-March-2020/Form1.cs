using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace IT_18_March_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region FileMenu
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            openFD.FileName = string.Empty;
            //openFD.Title = "Insert an image";
            openFD.Title = "Insert a Text File";
            openFD.Filter = "Text Files|*.txt|Word Documents|*.doc;*.docx";
            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled");
            }
            else
            {
                var ChosenFile = openFD.FileName;
                //pictureBox1.Image = Image.FromFile(ChosenFile);
                richTextBox1.LoadFile(ChosenFile, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
            saveFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            saveFD.FileName = "NewTextFile";
            //openFD.Title = "Insert an image";
            saveFD.Filter = "Text Files|*.txt";
            openFD.Title = "Saved a Text File";
            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {
                var SavedFile = saveFD.FileName;
                richTextBox1.SaveFile(SavedFile, RichTextBoxStreamType.PlainText);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        #region EditMenu
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != string.Empty)
            {
                textBox1.Cut();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo == true)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                textBox2.Paste();
                //Clipboard.Clear(); After we paste there isn't a need to delete the data from clipboard
            }
        }
        #endregion
        #region ViewMenu
        private void hideTextBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideTextBoxesToolStripMenuItem.Checked = !hideTextBoxesToolStripMenuItem.Checked;
            textBox1.Visible = !textBox1.Visible;
            textBox2.Visible = !textBox2.Visible;
        }

        private void hideUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideUIToolStripMenuItem.Checked = !hideUIToolStripMenuItem.Checked;
            menuStrip1.Visible = !menuStrip1.Visible;
        }

        private void hideImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideImagesToolStripMenuItem.Checked = !hideImagesToolStripMenuItem.Checked;
            pictureBox1.Visible = !pictureBox1.Visible;
        }
        #endregion


    }
}
