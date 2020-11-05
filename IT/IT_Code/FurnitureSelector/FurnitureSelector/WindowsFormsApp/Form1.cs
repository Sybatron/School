using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp.Properties;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        string oldChoice = string.Empty;
        Dictionary<string, Bitmap[]> itemsByCategory = new Dictionary<string, Bitmap[]>()
        {
            { "столове",new Bitmap[]{Properties.Resources.chair1, Properties.Resources.chair2, Properties.Resources.chair3, Properties.Resources.chair4} },
            { "маси",new Bitmap[]{Properties.Resources.table1, Properties.Resources.table2, Properties.Resources.table3, Properties.Resources.table4} },
            { "гардероби",new Bitmap[]{Properties.Resources.wardrobe1, Properties.Resources.wardrobe2, Properties.Resources.wardrobe3, Properties.Resources.wardrobe4} },
            { "легла",new Bitmap[]{Properties.Resources.bed1, Properties.Resources.bed2, Properties.Resources.bed3, Properties.Resources.bed4} },
        };
        Dictionary<string, string[]> itemsNames = new Dictionary<string, string[]>()
        {
            {"столове",new string[]{ "Евтин метален стол", "Неудобен стандартен стол", "Неудобен модерен стол", "Грозен стол на колелца"} },
            {"маси",new string[]{ "Кръгла стъклена маса", "Маса \"Седянката\"", "Mаса \"Полигона\"", "Кръглата маса"} },
            {"гардероби",new string[]{ "Голям модерен гардероб", "Малък дървен гардероб", "Гардероб \"Вектор\"", "Гардероб \"Minecraft edition\""} },
            {"легла",new string[]{ "Легло \"Minecraft edition\"", "Легло \"Счупи гръб\"", "Младоженско легло", "Двуетажно легло"} },
        };

        List<Control> panelControls = new List<Control>();


        public Form1()
        {
            InitializeComponent();
            progressBar.Visible = false;
            addButton.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (new[] { oldChoice, string.Empty }.All(x => x != objectOptionBox.Text))
            {
                oldChoice = objectOptionBox.Text;
                progressBar.Visible = true;
                formTimer.Start();
            }
            else
            {
                MessageBox.Show("ИЗБЕРИ ДРУГА КАТЕОРИЯ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadItems()
        {
            if (itemsByCategory.ContainsKey(oldChoice))
            {
                objectRB1.Image = itemsByCategory[oldChoice][0];
                objectRB2.Image = itemsByCategory[oldChoice][1];
                objectRB3.Image = itemsByCategory[oldChoice][2];
                objectRB4.Image = itemsByCategory[oldChoice][3];
            }
        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == 100)
            {
                formTimer.Stop();
                addButton.Visible = true;

                progressBar.Value = 0;
                viewButton.Enabled = false;
                loadItemsTimer.Start();
                return;
            }
            else
            {
                progressBar.Value += 10;
            }
            gridLayout.Height += 10;
            this.Height += 10;
            panel1.Height += 10;
        }

        private void loadItemsTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == 100)
            {
                loadItemsTimer.Stop();
                progressBar.Visible = false;
                viewButton.Enabled = true;
                loadItems();
            }
            else
            {
                progressBar.Value += 25;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var checkedRB = gridLayout.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var rbIndex = (int)char.GetNumericValue(checkedRB.Name.Last<char>());
            var labelText = itemsNames[oldChoice][rbIndex-1];
            var itemLabel = new Label();
            itemLabel.Text = labelText;
            itemLabel.Height = 200;
            itemLabel.Width = 400;
            itemLabel.Font = new Font("Comic Sans MS", 11);
            itemLabel.Visible = true;
            itemLabel.Show();
            panel1.Controls.Add(itemLabel);
        }
    }
}
