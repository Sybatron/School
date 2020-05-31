using BulgariaSightseeing.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BulgariaSightseeing
{
    public partial class AboutHistoryForm : Form
    {
        string city;
        string typeInfo;
        public AboutHistoryForm(string city, string typeInfo)
        {
            InitializeComponent();
            this.city = city;
            this.typeInfo = typeInfo;
            PlaceInfoPictures();
            PlaceInfoText();
        }

        private void PlaceInfoPictures()
        {
            if (city == "Велико Търново")
            {
                ChangePictures(new[] {
                    Resources.VelikoTarnovo1,
                    Resources.VelikoTarnovo2,
                    Resources.VelikoTarnovo3,
                    Resources.VelikoTarnovo4
                });
            }
            else if (city == "Сливен")
            {
                ChangePictures(new[] {
                    Resources.Sliven1,
                    Resources.Sliven2,
                    Resources.Sliven3,
                    Resources.Sliven4
                });
            }
            else if (city == "Варна")
            {
                ChangePictures(new[] {
                    Resources.Varna1,
                    Resources.Varna2,
                    Resources.Varna3,
                    Resources.Varna4
                });
            }
            else if (city == "Бургас")
            {
                ChangePictures(new[] {
                    Resources.Burgas1,
                    Resources.Burgas2,
                    Resources.Burgas3,
                    Resources.Burgas4
                });
            }
            else if (city == "София")
            {
                ChangePictures(new[] {
                    Resources.Sofia1,
                    Resources.Sofia2,
                    Resources.Sofia3,
                    Resources.Sofia4
                });
            }
        }

        private void ChangePictures(Image[] pics)
        {
            pictureBox1.Image = pics[0];
            pictureBox2.Image = pics[1];
            pictureBox3.Image = pics[2];
            pictureBox4.Image = pics[3];
        }

        private void PlaceInfoText()
        {
            if (city == "Велико Търново")
            {
                if (typeInfo == "history")
                {
                    infoTextBox.Text = Resources.VelikoTarnovoHistory;
                }
                else if (typeInfo == "info")
                {
                    infoTextBox.Text = Resources.VelikoTarnovoInfo;
                }
            }
            else if (city == "Сливен")
            {
                if (typeInfo == "history")
                {
                    infoTextBox.Text = Resources.SlivenHistory;
                }
                else if (typeInfo == "info")
                {
                    infoTextBox.Text = Resources.SlivenInfo;
                }
            }
            else if (city == "Варна")
            {
                if (typeInfo == "history")
                {
                    infoTextBox.Text = Resources.VarnaHistory;
                }
                else if (typeInfo == "info")
                {
                    infoTextBox.Text = Resources.VarnaInfo;
                }
            }
            else if (city == "Бургас")
            {
                if (typeInfo == "history")
                {
                    infoTextBox.Text = Resources.BurgasHistory;
                }
                else if (typeInfo == "info")
                {
                    infoTextBox.Text = Resources.BurgasInfo;
                }
            }
            else if (city == "София")
            {
                if (typeInfo == "history")
                {
                    infoTextBox.Text = Resources.SofiaHistory;
                }
                else if (typeInfo == "info")
                {
                    infoTextBox.Text = Resources.SofiaInfo;
                }
            }
        }

        private void backMenuItem_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
