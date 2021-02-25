using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Regex namePattern = new Regex(@"^[А-ЯA-Z][a-zа-я]{1,}( [A-ZА-Я][a-zа-я]\w{1,}){0,1}$");
        Regex classPattern = new Regex(@"([1-9]|10|11|12)[А-Д]");
        Dictionary<string, string> students = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            var student = new Student(numBox.Value, nameTB.Text, classTB.Text,
                belBox.Value, anglBox.Value, matBox.Value, fizBox.Value, himBox.Value, bioBox.Value);
            students[string.Format("{0}-{1}", student.Num, student.StudClass)] = student.ToString();
            using (var writer = new StreamWriter(Path.Combine(Application.StartupPath, "List.txt"), false))
            {
                foreach (var stud in students)
                {
                    writer.WriteLine(stud.Value);
                }
            }
        }
        private void readButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            using (var reader = new StreamReader(Path.Combine(Application.StartupPath, "List.txt")))
            {
                var line = reader.ReadLine();
                var result = new StringBuilder();
                while (line != null)
                {
                    result.AppendLine(line);
                    line = reader.ReadLine();
                }

                richTextBox1.Text = result.ToString();
            }
        }
        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            TimerReset();
            nameTB.ForeColor = Color.Black;
        }
        private void classTB_TextChanged(object sender, EventArgs e)
        {
            TimerReset();
            classTB.ForeColor = Color.Black;
        }

        private void gradeBox_ValueChanged(object sender, EventArgs e)
        {
            avgTB.Text = Math.Round((belBox.Value + anglBox.Value + matBox.Value + fizBox.Value + himBox.Value + bioBox.Value) / 6, 2).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (!namePattern.IsMatch(nameTB.Text))
            {
                nameTB.ForeColor = Color.Red;
                return;
            }
            if (!classPattern.IsMatch(classTB.Text))
            {
                classTB.ForeColor = Color.Red;
                return;
            }
            saveButton.Enabled = true;
        }
     
        void TimerReset()
        {
            saveButton.Enabled = false;
            timer1.Stop();
            timer1.Start();
        }

    }
}
