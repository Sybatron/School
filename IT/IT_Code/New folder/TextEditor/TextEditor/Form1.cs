using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        Font defaultFont;
        public Form1()
        {
            InitializeComponent();
            //DefaultExt = *.rtf; Filter = RTF Files(*.rtf) | *.rtf | TXT Files(*.txt) | *.txt

            openFileDialog1.DefaultExt = "rtf";
            openFileDialog1.Filter = "RTF Files(*.rtf)|*.rtf|TXT Files(*.txt)|*.txt";

            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.Filter = "RTF Files(*.rtf)|*.rtf|TXT Files(*.txt)|*.txt";

            fileNameStatusLabel.Text = string.Empty;
            newFileCreate();

            defaultFont = richTextBox1.Font;
        }
        #region File
        private void newMenuItem_Click(object sender, EventArgs e)
        {
            newFileCreate();
        }

        private void newFileCreate()
        {
            richTextBox1.Text = string.Empty;
            fileNameStatusLabel.Text = string.Empty;

            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);

            saveFileDialog1.FileName = string.Empty;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);

            richTextBox1.Font = defaultFont;
            richTextBox1.BackColor = Color.White;
            ClipboardEnable();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                openFileDialog1.FileName.Length > 0)
            {
                RichTextBoxStreamType streamType = openFileDialog1.FilterIndex == 1 
                                                    ? RichTextBoxStreamType.RichText 
                                                    : RichTextBoxStreamType.PlainText;

                richTextBox1.LoadFile(openFileDialog1.FileName, streamType);

                fileNameStatusLabel.Text = openFileDialog1.FileName;
                saveFileDialog1.FileName = openFileDialog1.FileName;
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName == string.Empty)
            {
                saveAsMenuItem_Click(sender, e);
            }
            else
            {
                RichTextBoxStreamType streamType = openFileDialog1.FilterIndex == 1
                                                    ? RichTextBoxStreamType.RichText
                                                    : RichTextBoxStreamType.PlainText;

                richTextBox1.SaveFile(saveFileDialog1.FileName, streamType);
            }
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK &&
            saveFileDialog1.FileName.Length > 0)
            {
                if (saveFileDialog1.FilterIndex == 1)
                {
                    saveFileDialog1.DefaultExt = "rtf";
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    saveFileDialog1.DefaultExt = "txt";
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            fileNameStatusLabel.Text = saveFileDialog1.FileName;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Edit
        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.SelectedText = string.Empty;
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = Clipboard.GetText();
        }
        #endregion
        #region Format
        private void changeFontMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();

            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
            else
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void backColorMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
            }
            else
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }
        #endregion
        #region View
        private void toolbarMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            toolbarMenuItem.Checked = !toolbarMenuItem.Checked;
        }

        private void statusBarMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
            statusBarMenuItem.Checked = !statusBarMenuItem.Checked;
        }
        #endregion
        #region Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mini Text editor", "Info about the app", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region Context Menu
        private void cutContextMenuItem_Click(object sender, EventArgs e)
        {
            cutMenuItem_Click(sender, e);
        }

        private void copyContextMenuItem_Click(object sender, EventArgs e)
        {
            copyMenuItem_Click(sender, e);
        }

        private void pasteContextMenuItem_Click(object sender, EventArgs e)
        {
            pasteMenuItem_Click(sender, e);
        }
        #endregion
        private void ClipboardEnable()
        {
            if (richTextBox1.SelectedText != string.Empty)
            {
                cutContextMenuItem.Enabled = true;
                cutMenuItem.Enabled = true;
                cutButton.Enabled = true;

                copyContextMenuItem.Enabled = true;
                copyMenuItem.Enabled = true;
                copyButton.Enabled = true;
            }
            else
            {
                cutContextMenuItem.Enabled = false;
                cutMenuItem.Enabled = false;
                cutButton.Enabled = false;

                copyContextMenuItem.Enabled = false;
                copyMenuItem.Enabled = false;
                copyButton.Enabled = false;
            }
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        { 
            if (e.Button == MouseButtons.Right)
            {
                ClipboardEnable();
                contextMenuStrip1.Show(Form1.MousePosition);
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            ClipboardEnable();
        }

        #region Toolbox
        private void newFileButton_Click(object sender, EventArgs e)
        {
            newMenuItem_Click(sender, e);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            openMenuItem_Click(sender, e);
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            saveMenuItem_Click(sender, e);
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            cutMenuItem_Click(sender, e);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            copyMenuItem_Click(sender, e);
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            pasteMenuItem_Click(sender, e);
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                var currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;
                var settings = new
                {
                    Bold = currentFont.Bold,
                    Italic = currentFont.Italic,
                    Underline = currentFont.Underline
                };

                if (settings.Bold)
                {
                    if (settings.Italic && settings.Underline) newFontStyle = FontStyle.Italic | FontStyle.Underline;
                    else if (settings.Italic) newFontStyle = FontStyle.Italic;
                    else if (settings.Underline) newFontStyle = FontStyle.Underline;
                    else newFontStyle = FontStyle.Regular;
                }
                else
                {
                    if (settings.Italic && settings.Underline) newFontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
                    else if (settings.Italic) newFontStyle = FontStyle.Bold | FontStyle.Italic;
                    else if (settings.Underline) newFontStyle = FontStyle.Bold | FontStyle.Underline;
                    else newFontStyle = FontStyle.Bold;
                }

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void italicsButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                var currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;
                var settings = new
                {
                    Bold = currentFont.Bold,
                    Italic = currentFont.Italic,
                    Underline = currentFont.Underline
                };

                if (settings.Italic)
                {
                    if (settings.Bold && settings.Underline) newFontStyle = FontStyle.Bold | FontStyle.Underline;
                    else if (settings.Bold) newFontStyle = FontStyle.Bold;
                    else if (settings.Underline) newFontStyle = FontStyle.Underline;
                    else newFontStyle = FontStyle.Regular;
                }
                else
                {
                    if (settings.Bold && settings.Underline) newFontStyle = FontStyle.Italic | FontStyle.Bold | FontStyle.Underline;
                    else if (settings.Bold) newFontStyle = FontStyle.Italic | FontStyle.Bold;
                    else if (settings.Underline) newFontStyle = FontStyle.Italic | FontStyle.Underline;
                    else newFontStyle = FontStyle.Italic;
                }

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                var currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;
                var settings = new
                {
                    Bold = currentFont.Bold,
                    Italic = currentFont.Italic,
                    Underline = currentFont.Underline
                };

                if (settings.Underline)
                {
                    if (settings.Italic && settings.Bold) newFontStyle = FontStyle.Italic | FontStyle.Bold;
                    else if (settings.Italic) newFontStyle = FontStyle.Italic;
                    else if (settings.Bold) newFontStyle = FontStyle.Bold;
                    else newFontStyle = FontStyle.Regular;
                }
                else
                {
                    if (settings.Italic && settings.Bold) newFontStyle = FontStyle.Underline | FontStyle.Italic | FontStyle.Bold;
                    else if (settings.Italic) newFontStyle = FontStyle.Underline | FontStyle.Italic;
                    else if (settings.Bold) newFontStyle = FontStyle.Underline | FontStyle.Bold;
                    else newFontStyle = FontStyle.Underline;
                }

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }
        #endregion
    }
}
