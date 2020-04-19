﻿using BulgariaSightseeing.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BulgariaSightseeing
{
    public partial class LandmarkGalleryForm : Form
    {
        string landmarkName;
        string city;
        string title;
        public LandmarkGalleryForm(string landmarkName, string city, string title)
        {
            InitializeComponent();
            this.landmarkName = landmarkName;
            this.city = city;
            this.title = title;
            PlaceLandmarkPictures();
        }

        private void PlaceLandmarkPictures()
        {
            if (city == "Велико Търново")
            {
                if (landmarkName == "Царевец")
                {
                    ChangePictures(new[] {
                        Resources.Carevec1,
                        Resources.Carevec2,
                        Resources.Carevec3,
                        Resources.Carevec4 });
                }
                else if (landmarkName == "Балдуинова кула")
                {
                    ChangePictures(new[] {
                        Resources.BauldTower1,
                        Resources.BauldTower2,
                        Resources.BauldTower3,
                        Resources.BauldTower4 });
                }
                else if (landmarkName == "Храм Св.40 Мъченици")
                {
                    ChangePictures(new[] {
                        Resources.St40Machenici1,
                        Resources.St40Machenici2,
                        Resources.St40Machenici3,
                        Resources.St40Machenici4 });
                }
                else if (landmarkName == "Трапезица")
                {
                    ChangePictures(new[] {
                        Resources.Trapezica1,
                        Resources.Trapezica2,
                        Resources.Trapezica3,
                        Resources.Trapezica4 });
                }
            }
            else if (city == "Сливен")
            {
                if (landmarkName == "Кутелка")
                {
                    ChangePictures(new[] {
                        Resources.Kutelka1,
                        Resources.Kutelka2,
                        Resources.Kutelka3,
                        Resources.Kutelka4 });
                }
                else if (landmarkName == "Крепост Туида")
                {
                    ChangePictures(new[] {
                        Resources.TuidaFortress1,
                        Resources.TuidaFortress2,
                        Resources.TuidaFortress3,
                        Resources.TuidaFortress4 });
                }
                else if (landmarkName == "Музей текстилна индустрия")
                {
                    ChangePictures(new[] {
                        Resources.TextileIndustryMuseum1,
                        Resources.TextileIndustryMuseum2,
                        Resources.TextileIndustryMuseum3,
                        Resources.TextileIndustryMuseum4 });
                }
                else if (landmarkName == "Къща-Музей Хаджи Димитър")
                {
                    ChangePictures(new[] {
                        Resources.HadgiDimitarHouse1,
                        Resources.HadgiDimitarHouse2,
                        Resources.HadgiDimitarHouse3,
                        Resources.HadgiDimitarHouse4 });
                }
            }
            else if (city == "Варна")
            {
                if (landmarkName == "Делфинариум")
                {
                    ChangePictures(new[] {
                        Resources.DolphinVarna1,
                        Resources.DolphinVarna2,
                        Resources.DolphinVarna3,
                        Resources.DolphinVarna4 });
                }
                else if (landmarkName == "Ретро Музей")
                {
                    ChangePictures(new[] {
                        Resources.RetroMuseum1,
                        Resources.RetroMuseum2,
                        Resources.RetroMuseum3,
                        Resources.RetroMuseum4 });
                }
                else if (landmarkName == "Римски терми")
                {
                    ChangePictures(new[] {
                        Resources.RomeRuins1,
                        Resources.RomeRuins2,
                        Resources.RomeRuins3,
                        Resources.RomeRuins4 });
                }
                else if (landmarkName == "Храм \"Юспение богородично\"")
                {
                    ChangePictures(new[] {
                        Resources.UspenieBogorodichno1,
                        Resources.UspenieBogorodichno2,
                        Resources.UspenieBogorodichno3,
                        Resources.UspenieBogorodichno4 });
                }
            }
        }

        private void ChangePictures(Image[] pics)
        {
            landmarkPictureBox1.Image = pics[0];
            landmarkPictureBox2.Image = pics[1];
            landmarkPictureBox3.Image = pics[2];
            landmarkPictureBox4.Image = pics[3];
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
