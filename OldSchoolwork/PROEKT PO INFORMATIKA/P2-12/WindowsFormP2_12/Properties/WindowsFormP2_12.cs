using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormP2_12
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            errorLab.Text = "";
            doItB.Visible = false;
        }

        double a, b, c;
        bool isRight;

        private void aBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(aBox.Text);
                isRight = true;
            }
            catch (FormatException)
            {
                errorLab.Text = "Грешно въведени данни";
                isRight = false;
            }
        }

        private void bBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doItB_Click(object sender, EventArgs e)
        {

        }

        private void clearB_Click(object sender, EventArgs e)
        {

        }

        private void WindowsFormP2_12_Activated(object sender, EventArgs e)
        {

        }
    }
}
