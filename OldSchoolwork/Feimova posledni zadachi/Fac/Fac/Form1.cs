using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fac
{
    public partial class Form1 : Form
    {
        uint N;
        public Form1()
        {
            InitializeComponent();
            facNumLab.ResetText();
            facLab.ResetText();
            DoItB.Visible = false;
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            facNumLab.ResetText();
            facLab.ResetText();
            nBox.ResetText();
            DoItB.Visible = false;
        }

        private void DoItB_Click(object sender, EventArgs e)
        {
            facNumLab.Text=Fac(N).ToString();
        }

        private void nBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                N = uint.Parse(nBox.Text);
                DoItB.Visible = true;
            }
            catch (FormatException)
            {
                DoItB.Visible = false;
                N = 1;
            }
        }

        ulong Fac(uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            else return Fac(n-1)*n;
        }
    }
}
