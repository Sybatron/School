using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsP3_22
{
    public partial class Form : System.Windows.Forms.Form
    {
        int N = 0;
        public Form()
        {
            InitializeComponent();
            doItB.Visible = false;
            resultLab.ResetText();
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            doItB.Visible = false;
            resultLab.ResetText();
            nBox.ResetText();
        }

        private void doItB_Click(object sender, EventArgs e)
        {
            double a=0;/*Променлива за сбора*/
            if (N != 1)
            {
                for (int i = N; i >= 1; i--)
                {
                    /*В цикъл пресмятаме сбора на
                     първите N елемнта на хармоничната редица
                     и ги записваме в a*/
                    a += 1.0 / i;
                }
            }
            else a = 1;/*Ако N е 1, то 1/1 е едно*/
            a = Math.Round(a,2);/*Накрая закръгляме дробта*/
            /*И извеждаме сумата на първите N елемента в хармоничната редица*/
            resultLab.Text = a.ToString();
        }

        private void nBox_TextChanged(object sender, EventArgs e)
        {
            /*При всяка промяна на текст бокса проверяваме дали N е цяло число*/
            bool isRight = false;
            try
            {
                N = int.Parse(nBox.Text);
                isRight = true;
            }
            catch (FormatException)
            {
                isRight = false;
            }
            /*Ако да бутонът за пресмятане се появява*/
            if(isRight)
            {
                doItB.Visible = true;
            }
            else doItB.Visible = false;
        }
    }
}
