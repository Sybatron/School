using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsP3_23
{
    public partial class Form1 : Form
    {
        uint N=0;
        public Form1()
        {
            InitializeComponent();
            doItB.Visible = false;
            resultLab.ResetText();
            nFacLab.ResetText();
        }
        private void nBox_TextChanged(object sender, EventArgs e)
        {
            bool isRight = false;
            try
            {
                N = uint.Parse(nBox.Text);
                isRight = true;
            }
            catch (FormatException)
            {
                isRight = false;
            }

            if (isRight)
            {
                doItB.Visible = true;
                nFacLab.Text = N.ToString() + "!";
            }
            else doItB.Visible = false;
        }  

        private void doItB_Click(object sender, EventArgs e)
        {
            resultLab.Text = fac(N).ToString();
        }
        private void clearB_Click(object sender, EventArgs e)
        {
            doItB.Visible = false;
            resultLab.ResetText();
            nBox.ResetText();
            nFacLab.ResetText();
        }

        ulong fac(uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            else return n * (n - 1);
        }
    }
}
