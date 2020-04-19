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
            var aboutForm = new AboutHistoryForm();

            void ChangeFormTitle(string town, Form formToChange)
            {
                formToChange.Text = $"Информация за {town}";
            }

            if (townsMenuStrip.SourceControl == sofiaLabel)
            {
                ChangeFormTitle("София", aboutForm);
            }
            if (townsMenuStrip.SourceControl == vTarnovoLabel)
            {
                ChangeFormTitle("Велико Търново", aboutForm);
            }
            if (townsMenuStrip.SourceControl == slivenLabel)
            {
                ChangeFormTitle("Сливен", aboutForm);
            }
            if (townsMenuStrip.SourceControl == burgasLabel)
            {
                ChangeFormTitle("Бургас", aboutForm);
            }
            if (townsMenuStrip.SourceControl == varnaLabel)
            {
                ChangeFormTitle("Варна", aboutForm);
            }

            this.Hide();
            aboutForm.ShowDialog();
            this.Close();
        }

        private void historyMenuItem_Click(object sender, EventArgs e)
        {
            var historyForm = new AboutHistoryForm();

            void ChangeFormTitle(string town, Form formToChange)
            {
                formToChange.Text = $"История на {town}";
            }

            if (townsMenuStrip.SourceControl == sofiaLabel)
            {
                ChangeFormTitle("София", historyForm);
            }
            if (townsMenuStrip.SourceControl == vTarnovoLabel)
            {
                ChangeFormTitle("Велико Търново", historyForm);
            }
            if (townsMenuStrip.SourceControl == slivenLabel)
            {
                ChangeFormTitle("Сливен", historyForm);
            }
            if (townsMenuStrip.SourceControl == burgasLabel)
            {
                ChangeFormTitle("Бургас", historyForm);
            }
            if (townsMenuStrip.SourceControl == varnaLabel)
            {
                ChangeFormTitle("Варна", historyForm);
            }

            this.Hide();
            historyForm.ShowDialog();
            this.Close();
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
