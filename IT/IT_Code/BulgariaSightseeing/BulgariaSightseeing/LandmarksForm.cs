using BulgariaSightseeing.Properties;
using System;
using System.Windows.Forms;

namespace BulgariaSightseeing
{
    public partial class LandmarksForm : Form
    {
        string landmarkName;
        string city;
        public LandmarksForm(string city)
        {
            InitializeComponent();
            infoTextBox.Visible = true;
            maximizePictureBox.Visible = false;
            this.city = city;
            PlaceLandmarksPictures();
        }

        private void PlaceLandmarksPictures()
        {
            if (city == "Велико Търново")
            {
                landmarkPictureBox1.Image = Resources.CarevecMain;
                landmarkLabel1.Text = "Царевец";
                landmarkPictureBox2.Image = Resources.BauldTowerMain;
                landmarkLabel2.Text = "Балдуинова кула";
                landmarkPictureBox3.Image = Resources.St40MacheniciMain;
                landmarkLabel3.Text = "Храм Св.40 Мъченици";
                landmarkPictureBox4.Image = Resources.TrapezicaMain;
                landmarkLabel4.Text = "Трапезица";
            }
            else if (city == "Сливен")
            {
                landmarkPictureBox1.Image = Resources.KutelkaMain;
                landmarkLabel1.Text = "Кутелка";
                landmarkPictureBox2.Image = Resources.TuidaFortressMain;
                landmarkLabel2.Text = "Крепост Туида";
                landmarkPictureBox3.Image = Resources.TextileIndustryMuseumMain;
                landmarkLabel3.Text = "Музей текстилна индустрия";
                landmarkPictureBox4.Image = Resources.HadgiDimitarHouseMain;
                landmarkLabel4.Text = "Къща-Музей Хаджи Димитър";
            }
            else if (city == "Варна")
            {
                landmarkPictureBox1.Image = Resources.DolphinVarnaMain;
                landmarkLabel1.Text = "Делфинариум";
                landmarkPictureBox2.Image = Resources.RetroMuseumMain;
                landmarkLabel2.Text = "Ретро Музей";
                landmarkPictureBox3.Image = Resources.RomeRuinsMain;
                landmarkLabel3.Text = "Римски терми";
                landmarkPictureBox4.Image = Resources.UspenieBogorodichnoMain;
                landmarkLabel4.Text = "Храм \"Юспение богородично\"";
            }
            else if (city == "Бургас")
            {
                landmarkPictureBox1.Image = Resources.ArchaeologyMuseumMain;
                landmarkLabel1.Text = "Археологически музей";
                landmarkPictureBox2.Image = Resources.PodaMain;
                landmarkLabel2.Text = "Природозащитен център ПОДА";
                landmarkPictureBox3.Image = Resources.SeaGardenMain;
                landmarkLabel3.Text = "Морската градина";
                landmarkPictureBox4.Image = Resources.SvetaAnastasiaMain;
                landmarkLabel4.Text = "Манастир \"Света Анастасия\"";
            }
            else if (city == "София")
            {
                landmarkPictureBox1.Image = Resources.BoyanskaCarkvaMain;
                landmarkLabel1.Text = "Боянска църква";
                landmarkPictureBox2.Image = Resources.StAlexanderNevskiMain;
                landmarkLabel2.Text = "Св. Александър Невски";
                landmarkPictureBox3.Image = Resources.StGeorgeMain;
                landmarkLabel3.Text = "Ротонда \"Св. Георги\"";
                landmarkPictureBox4.Image = Resources.VitoshaMain;
                landmarkLabel4.Text = "Витоша";
            }
        }

        private void maximazeMenuItem_Click(object sender, EventArgs e)
        {
            var image = (landmarksContextMenuStrip.SourceControl as PictureBox).Image;
            maximizePictureBox.Image = image;
            maximizePictureBox.Visible = true;
        }

        private void infoMenuItem_Click(object sender, EventArgs e)
        {
            FindLandmarkName();
            var infoForm = new LandmarkInfo(landmarkName, city, this.Text);
            this.Hide();
            infoForm.ShowDialog();
            this.Close();
        }

        private void galleryMenuItem_Click(object sender, EventArgs e)
        {
            FindLandmarkName();
            var galleryForm = new LandmarkGalleryForm(landmarkName, city, this.Text);
            this.Hide();
            galleryForm.ShowDialog();
            this.Close();
        }

        private void FindLandmarkName()
        {
            switch (landmarksContextMenuStrip.SourceControl.Name)
            {
                case "landmarkPictureBox1":
                    landmarkName = landmarkLabel1.Text;
                    break;
                case "landmarkPictureBox2":
                    landmarkName = landmarkLabel2.Text;
                    break;
                case "landmarkPictureBox3":
                    landmarkName = landmarkLabel3.Text;
                    break;
                case "landmarkPictureBox4":
                    landmarkName = landmarkLabel4.Text;
                    break;
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

        private void backToLandmarksMenuItem_Click(object sender, EventArgs e)
        {
            optionContextMenuStrip.SourceControl.Visible = false;
        }
    }
}
