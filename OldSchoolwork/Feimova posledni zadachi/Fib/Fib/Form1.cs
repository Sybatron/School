using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fib
{
    public partial class Form1 : Form
    {
        uint N;
        public Form1()
        {
            InitializeComponent();
            fibNumLab.ResetText();
            fibLab.ResetText();
            DoItB.Visible = false;
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

        private void DoItB_Click(object sender, EventArgs e)
        {
            fibNumLab.Text = Fib(N).ToString();
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            fibNumLab.ResetText();
            fibLab.ResetText();
            nBox.ResetText();
            DoItB.Visible = false;
        }

        ulong Fib(uint n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 1;
            }
            else return Fib(n - 1) + Fib(n - 2);
        }
    }
}
