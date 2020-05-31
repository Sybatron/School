using System;
using System.Windows.Forms;

namespace BulgariaSightseeing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void forTownMenuItem_Click(object sender, EventArgs e)
        {

            void ChangeFormTitle(string town, Form formToChange)
            {
                formToChange.Text = $"Информация за {town}";
            }

            void CreateInfoForm(string town, string typeInfo)
            {
                var aboutForm = new AboutHistoryForm(town, typeInfo);
                ChangeFormTitle(town, aboutForm);
                this.Hide();
                aboutForm.ShowDialog();
                this.Close();
            }

            var type = "info";

            if (townsMenuStrip.SourceControl == sofiaLabel)
            {
                CreateInfoForm("София", type);
            }
            else if (townsMenuStrip.SourceControl == vTarnovoLabel)
            {
                CreateInfoForm("Велико Търново", type);
            }
            else if (townsMenuStrip.SourceControl == slivenLabel)
            {
                CreateInfoForm("Сливен", type);
            }
            else if (townsMenuStrip.SourceControl == burgasLabel)
            {
                CreateInfoForm("Бургас", type);
            }
            else if (townsMenuStrip.SourceControl == varnaLabel)
            {
                CreateInfoForm("Варна", type);
            }
        }

        private void historyMenuItem_Click(object sender, EventArgs e)
        {
            void ChangeFormTitle(string town, Form formToChange)
            {
                formToChange.Text = $"История на {town}";
            }

            void CreateHistoryForm(string town, string typeInfo)
            {
                var aboutForm = new AboutHistoryForm(town, typeInfo);
                ChangeFormTitle(town, aboutForm);
                this.Hide();
                aboutForm.ShowDialog();
                this.Close();
            }

            if (townsMenuStrip.SourceControl == sofiaLabel)
            {
                CreateHistoryForm("София", "history");
            }
            else if (townsMenuStrip.SourceControl == vTarnovoLabel)
            {
                CreateHistoryForm("Велико Търново", "history");
            }
            else if (townsMenuStrip.SourceControl == slivenLabel)
            {
                CreateHistoryForm("Сливен", "history");
            }
            else if (townsMenuStrip.SourceControl == burgasLabel)
            {
                CreateHistoryForm("Бургас", "history");
            }
            else if (townsMenuStrip.SourceControl == varnaLabel)
            {
                CreateHistoryForm("Варна", "history");
            }
        }

        private void landmarksMenuItem_Click(object sender, EventArgs e)
        {
            void ChangeFormTitle(string town, Form formToChange)
            {
                formToChange.Text = $"Забележителности в {town}";
            }

            void CreateGalleryForm(string town)
            {
                var landmarkForm = new LandmarksForm(town);
                ChangeFormTitle(town, landmarkForm);
                this.Hide();
                landmarkForm.ShowDialog();
                this.Close();
            }

            if (townsMenuStrip.SourceControl == sofiaLabel)
            {
                CreateGalleryForm("София");
            }
            if (townsMenuStrip.SourceControl == vTarnovoLabel)
            {
                CreateGalleryForm("Велико Търново");
            }
            if (townsMenuStrip.SourceControl == slivenLabel)
            {
                CreateGalleryForm("Сливен");
            }
            if (townsMenuStrip.SourceControl == burgasLabel)
            {
                CreateGalleryForm("Бургас");
            }
            if (townsMenuStrip.SourceControl == varnaLabel)
            {
                CreateGalleryForm("Варна");
            }
        }
    }
}
