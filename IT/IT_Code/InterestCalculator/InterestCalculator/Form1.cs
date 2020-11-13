using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultLabel.Text = string.Empty;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var selectionRange = calendarElement.SelectionRange;
            if (selectionRange.End == selectionRange.Start)
            {
                MessageBox.Show("Подайте диапазон!");
                return;
            }

            try
            {
                var days = selectionRange.End.Subtract(selectionRange.Start).Days;

                var depositValue = double.Parse(moneyTB.Text);
                var interestPercentage = double.Parse(interestTB.Text) / 100;

                var result = depositValue * Math.Pow((1 + interestPercentage), double.Parse(days.ToString()));

                resultLabel.Text = $"{result:0.00}";
            }
            catch (Exception)
            {
                MessageBox.Show("Празни или грешно въведени данни!");
            }
        }
    }
}
