using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectButton
{
    public partial class Form1 : Form
    {
        int br = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void clickB_MouseDown(object sender, MouseEventArgs e)
        {
            br++;
            if (br == 7) Application.Exit();
        }

        private void clickB_MouseUp(object sender, MouseEventArgs e)
        {
            clickB.Text = br.ToString() + " пъти";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }
    }
}
