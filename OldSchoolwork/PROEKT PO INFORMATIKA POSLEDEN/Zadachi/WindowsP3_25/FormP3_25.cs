using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsP3_25
{
    public partial class Form1 : Form
    {
        bool aChecked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void aRB_CheckedChanged(object sender, EventArgs e)
        {
            mBox.Visible = false;
            nBox.Visible = false;
            nLab.Visible = false;
            mLab.Visible = false;
            aChecked = true;
        }

        private void bRB_CheckedChanged(object sender, EventArgs e)
        {
            mBox.Visible = true;
            nBox.Visible = true;
            nLab.Visible = true;
            mLab.Visible = true;
            aChecked = false;
        }

        private void doItB_Click(object sender, EventArgs e)
        {
            listView.ResetText();
            string help="0\"-";
            if (aChecked)
            {
                for (int i = 1; i <= 40; i++)
                {
                    help = help.Replace((i - 1).ToString(), i.ToString());
                    listView.AppendText(help+(i * 2.54).ToString() + "см\n");
                }
            }
            else
            {
                int m=0, n=0;
                try
                {
                    m = int.Parse(mBox.Text);
                    n = int.Parse(nBox.Text);
                }
                catch (FormatException)
                {
                }
                finally
                {
                    help = help.Replace("0", (m-1).ToString());
                    for (int i = m; i <= n; i++)
                    {
                        help = help.Replace((i - 1).ToString(), i.ToString());
                        listView.AppendText(help+(i * 2.54).ToString()+"см\n");
                    }
                }
            }
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            mBox.ResetText();
            nBox.ResetText();
            listView.ResetText();
        }      
    }
}
