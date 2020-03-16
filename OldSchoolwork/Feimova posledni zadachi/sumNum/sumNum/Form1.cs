using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sumNum
{
    public partial class Form1 : Form
    {
        ulong N;
        public Form1()
        {
            InitializeComponent();
            sumNumsLab.ResetText();
            DoItB.Visible = false;
        }

        private void DoItB_Click(object sender, EventArgs e)
        {
            sumNumsLab.Text = sumNums(N).ToString();
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            sumNumsLab.ResetText();
            nBox.ResetText();
            DoItB.Visible = false;
        }

        private void nBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                N = ulong.Parse(nBox.Text);
                DoItB.Visible = true;
            }
            catch (FormatException)
            {
                DoItB.Visible = false;
                N = 1;
            }
        }

        ulong sumNums(ulong n)
        {
            if (n/10==0)
            {
                return n % 10;
            }
            else return sumNums(n/10)+n%10;
        }
    }
}
