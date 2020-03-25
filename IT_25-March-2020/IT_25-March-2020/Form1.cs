using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IT_25_March_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void birthdayButton_Click(object sender, EventArgs e)
        {
            var happyBirthday = new HappyBirthday(presentCountTextBox.Text);
            if (presentCountTextBox.Text.Length > 0)
            {
                MessageBox.Show(happyBirthday.GetMessage());
            }
            else
            {
                MessageBox.Show("The present count can't be empty");
            }
        }

        private void birthdayNameButton_Click(object sender, EventArgs e)
        {
            var happBirthday = new HappyBirthday(presentCountTextBox.Text);
            if (nameTextBox.Text.Length > 0 && presentCountTextBox.Text.Length > 0)
            {
                MessageBox.Show(happBirthday.GetMessage(nameTextBox.Text));
            }
            else
            {
                MessageBox.Show("The textboxes can't be empty");
            }
        }

        private void partyButton_Click(object sender, EventArgs e)
        {
            var party = new BirthdayParty(presentCountTextBox.Text);
            if (nameTextBox.Text.Length > 0 && presentCountTextBox.Text.Length > 0)
            {
                MessageBox.Show(party.GetMessage(nameTextBox.Text, havePartyCB.Checked));
            }
            else
            {
                MessageBox.Show("The textboxes can't be empty");
            }
        }

        private void partyProgressButton_Click(object sender, EventArgs e)
        {
            BirthdayParty.PartyProgress(presentCountTextBox, nameTextBox, havePartyCB);
        }
    }
}
