using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRent
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> carPrices = new Dictionary<string, double>()
        {
                { "Audi A4",40 },
                { "Mazda6",35 },
                { "Renault Clio",30 },
                { "Toyota Avensis",50 },
                { "Toyota Land Cruiser",60 },
                { "VW Multivan",55 }
        };
        public Form1()
        {
            InitializeComponent();
            dailyPriceLabel.Text = string.Empty;
            resultLabel.Text = string.Empty;
        }

        private void carSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dailyPriceLabel.Text = carPrices[carSelectorComboBox.Text].ToString() + " лв.";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (dailyPriceLabel.Text == string.Empty)
            {
                MessageBox.Show("Изберете кола");
                return;
            }
            if (calendarElement.SelectionEnd.Date == calendarElement.SelectionStart.Date)
            {
                MessageBox.Show("Изберете диапазон от време");
                return;
            }

            double fullPrice = 0;

            foreach (CheckBox CB in asstetsGB.Controls)
            {
                if (CB.Checked)
                {
                    fullPrice += double.Parse(CB.Tag.ToString());
                }
            }
            
            var dailyPrice = carPrices[carSelectorComboBox.Text];
            var selectionRange = calendarElement.SelectionRange;
            var days = selectionRange.End.Subtract(selectionRange.Start).Days;
            var percentage = days >= 14 ? 15
                            : days >= 7 ? 10
                            : days >= 3 ? 5
                            : 0;

            fullPrice += dailyPrice * (1 - percentage / 100.0) * days;

            resultLabel.Text = string.Format($"{fullPrice:0.00} с {percentage}% отстъпка");
        }
    }
}
