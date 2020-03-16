using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsP3_24
{
    public partial class Form1 : Form
    {
        int N = 0;
        public Form1()
        {
            InitializeComponent();
            doItB.Visible = false;
            resultLab.ResetText();
            nFacLab.ResetText();
        }

        private void doItB_Click(object sender, EventArgs e)
        {
            ulong multiply = 1;
            if (N != 0)
            {
                if (N % 2 == 0)
                {
                    for (uint i = 2; i <= N; i += 2)
                    {
                        multiply *= i;
                    }
                }
                else for (uint i = 1; i <= N; i += 2)
                    {
                        multiply *= i;
                    }
            }
            else multiply = 0;
            resultLab.Text = multiply.ToString();
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            doItB.Visible = false;
            resultLab.ResetText();
            nBox.ResetText();
            nFacLab.ResetText();
        }

        private void nBox_TextChanged(object sender, EventArgs e)
        {
            bool isRight = false;
            try
            {
                N = int.Parse(nBox.Text);
                isRight = true;
            }
            catch (FormatException)
            {
                isRight = false;
            }

            if (isRight)
            {
                doItB.Visible = true;
                nFacLab.Text = N.ToString() + "!!";
            }
            else doItB.Visible = false;
        }
    }
}
