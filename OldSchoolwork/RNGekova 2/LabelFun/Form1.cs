using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RNGekova_2
{
    public partial class Form1 : Form
    {
        Point abc;
        int x = 0, y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            label1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            if (label1.Location.X != MousePosition.X)
            {
                if (label1.Location.X > x)
                {
                    abc.X = label1.Location.X - x;
                    abc.X = label1.Location.X + abc.X;
                    abc.Y = label1.Location.Y;
                    label1.Location = abc;
                }
                else
                {
                    abc.X = label1.Location.X - x + label1.Width*90/100;
                    abc.X = label1.Location.X + abc.X;
                    abc.Y = label1.Location.Y;
                    label1.Location = abc;
                }
            }

            if (label1.Location.Y != MousePosition.Y)
            {
                if (label1.Location.Y > y)
                {
                    abc.Y = label1.Location.Y - y;
                    abc.Y = label1.Location.Y + abc.Y;
                    abc.X = label1.Location.X;
                    label1.Location = abc;
                }
                else
                {
                    abc.Y = label1.Location.Y - y + label1.Height*20/100;;
                    abc.Y = label1.Location.Y + abc.Y;
                    abc.X = label1.Location.X;
                    label1.Location = abc;
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            label2.Text = "X = " + e.X + " Y = " + e.Y;
            label3.Text = "LabX = " + label1.Location.X + " LabY = " + label1.Location.Y;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Location=new Point(240,140);
        }
    }
}
