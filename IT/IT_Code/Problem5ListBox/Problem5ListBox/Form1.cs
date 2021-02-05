using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Problem5ListBox
{
    public partial class Form1 : Form
    {
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var index = listBox1.FindString(listBoxInput.Value.ToString(), -1);
            //if (index >= 0)
            //{
            //    MessageBox.Show("Duplicate");
            //}
            //else
            //{
                listBox1.Items.Add(listBoxInput.Text);
            //}
            TextBoxClear();
        }
        void TextBoxClear()
        {
            listBoxInput.Value = 0;
            listBoxInput.Focus();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in listBox1.Items)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items[comboBox1.SelectedIndex] = comboBoxInput.Text;
            listBox1.Items.Clear();
            foreach (var item in comboBox1.Items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxInput.Value = decimal.Parse(comboBox1.SelectedItem.ToString());
        }

        private void redrawButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                chart1.Series["Tempreture"].Points.Clear();
                var date = DateTime.Now;
                
                foreach (var item in listBox1.Items)
                {
                    chart1.Series["Tempreture"].Points.AddXY(date.ToString("dd/MM/yy"), item);
                    date = date.AddDays(1);
                }
            }
        }
    }
}
