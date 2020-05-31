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
    public partial class LandmarkInfo : Form
    {
        string landmarkName;
        string city;
        string title;
        public LandmarkInfo(string landmarkName, string city, string title)
        {
            InitializeComponent();
            this.landmarkName = landmarkName;
            this.city = city;
            this.title = title;
            PlaceLandmarksInfo();
        }

        private void PlaceLandmarksInfo()
        {
            if (city == "Велико Търново")
            {
                if (landmarkName == "Царевец")
                {
                    infoTextBox.Text = Resources.CarevecInfo;
                }
                else if (landmarkName == "Балдуинова кула")
                {
                    infoTextBox.Text = Resources.BauldTowerInfo;
                }
                else if (landmarkName == "Храм Св.40 Мъченици")
                {
                    infoTextBox.Text = Resources.St40MacheniciInfo;
                }
                else if (landmarkName == "Трапезица")
                {
                    infoTextBox.Text = Resources.TrapezicaInfo;
                }
            }
            else if (city == "Сливен")
            {
                if (landmarkName == "Кутелка")
                {
                    infoTextBox.Text = Resources.KutelkaInfo;
                }
                else if (landmarkName == "Крепост Туида")
                {
                    infoTextBox.Text = Resources.TuidaFortressInfo;
                }
                else if (landmarkName == "Музей текстилна индустрия")
                {
                    infoTextBox.Text = Resources.TextileIndustryMuseumInfo;
                }
                else if (landmarkName == "Къща-Музей Хаджи Димитър")
                {
                    infoTextBox.Text = Resources.HadgiDimitarHouseInfo;
                }
            }
            else if (city == "Варна")
            {
                if (landmarkName == "Делфинариум")
                {
                    infoTextBox.Text = Resources.DolphinVarnaInfo;
                }
                else if (landmarkName == "Ретро Музей")
                {
                    infoTextBox.Text = Resources.RetroMuseumInfo;
                }
                else if (landmarkName == "Римски терми")
                {
                    infoTextBox.Text = Resources.RomeRuinsInfo;
                }
                else if (landmarkName == "Храм \"Юспение богородично\"")
                {
                    infoTextBox.Text = Resources.UspenieBogorodichnoInfo;
                }
            }
            else if (city == "Бургас")
            {
                if (landmarkName == "Археологически музей")
                {
                    infoTextBox.Text = Resources.ArchaeologyMuseumInfo;
                }
                else if (landmarkName == "Природозащитен център ПОДА")
                {
                    infoTextBox.Text = Resources.PodaInfo;
                }
                else if (landmarkName == "Морската градина")
                {
                    infoTextBox.Text = Resources.SeaGardenInfo;
                }
                else if (landmarkName == "Манастир \"Света Анастасия\"")
                {
                    infoTextBox.Text = Resources.SvetaAnastasiaInfo;
                }
            }
            else if (city == "София")
            {
                if (landmarkName == "Боянска църква")
                {
                    infoTextBox.Text = Resources.BoyanskaCarkvaInfo;
                }
                else if (landmarkName == "Св. Александър Невски")
                {
                    infoTextBox.Text = Resources.StAlexanderNevskiInfo;
                }
                else if (landmarkName == "Ротонда \"Св. Георги\"")
                {
                    infoTextBox.Text = Resources.StGeorgeInfo;
                }
                else if (landmarkName == "Витоша")
                {
                    infoTextBox.Text = Resources.VitoshaInfo;
                }
            }
        }

        private void backMenuItem_Click(object sender, EventArgs e)
        {
            var landmarksForm = new LandmarksForm(city);
            this.Hide();
            landmarksForm.Text = title;
            landmarksForm.ShowDialog();
            this.Close();
        }
    }
}
