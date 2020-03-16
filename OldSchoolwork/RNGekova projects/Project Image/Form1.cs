using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Image
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = imageList1.Images[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = imageList1.Images[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
// string fileName = openFileDialog1.FileName; 
//if (fileName. - около 17 вида разширения за избражение 

try { this.BackgroundImage = Image.FromFile (openFileDialog1.FileName); } 
catch { MessageBox.Show("Проблем с файла!"); } 
} } 
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
