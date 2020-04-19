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
