using System;
using System.Windows.Forms;

namespace WindowsForm_P2_41
{
    public partial class Form1 : Form
    {
        bool isRight;//Променлива за проверка дали са въведени числа
        double x1, y1, x2, y2, x3, y3;//Променливи за кординатите

        /*  В началото бутона за намиране на най-ниската точка изчезва(findPointB) и се изчиства текстът на
         errorLab. */ 
        public Form1()
        {
            InitializeComponent();
            errorLab.Text = "";
            findPointB.Visible = false;
        }

        /*  При промяна на текста се извиква методът check, който проверява дали
        са въведени само числа. */
        private void x1Box_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void x2Box_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void x3Box_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void y1Box_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void y2Box_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void y3Box_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        /*   Когато се натисне бутона за намиране на най-ниската точката:
         * Намира се най-ниската точка
         * Накрая се проверява и се извеждат кординатите и, съответно в
           lowestXLab и lowestYLab. */
        private void findPointB_Click(object sender, EventArgs e)
        {
            double lowest = Math.Min(y1, y2);
            lowest = Math.Min(lowest, y3);//Намиране на най-ниската точка
            /* Търси на съвпадение с някои от кординатите и след това извежда най-ниската точка*/
            if (lowest == y1)
            {
                lowestXLab.Text = "Кордината x на най-ниската точка: " + x1.ToString();
                lowestYLab.Text = "Кордината y на най-ниската точка: " + y1.ToString();
            }
            else if (lowest == y2)
            {
                lowestXLab.Text = "Кордината x на най-ниската точка: " + x2.ToString();
                lowestYLab.Text = "Кордината y на най-ниската точка: " + y2.ToString();
            }
            else
            {
                lowestXLab.Text = "Кордината x на най-ниската точка: " + x3.ToString();
                lowestYLab.Text = "Кордината y на най-ниската точка: " + y3.ToString();
            }
        }

        /*  -Когато се натисне бутонът за изчистване, в текст боксовете за въвеждане на кординати им се премахва текста в тях.
            -Премахва се текста в лейбъла errorLab
            -lowestYLab и lowestXLab се връщат в първоначалното им състояние(когато е била пусната програмата) */
        private void clearB_Click(object sender, EventArgs e)
        {
            x1Box.Text = "";
            y1Box.Text = "";
            x2Box.Text = "";
            y2Box.Text = "";
            x3Box.Text = "";
            y3Box.Text = "";
            lowestXLab.Text = "Кординатата X на най-ниската точка";
            lowestYLab.Text = "Кординатата Y на най-ниската точка";
            errorLab.Text = "";
        }

        /*  Методът check проверява дали са въведени само числа и ако не се извежда грешка в
          errorLab "Грешно въведени данни". Накрая се вика метода refreshing. */
        void check()
        {
            /* Пробва се да превърне текста от текст боксовете за въвеждане на кординатите в тип double и да ги запише
             в променливите, в които трябва да се запишат кординатите. */
            try
            {
                x1 = double.Parse(x1Box.Text);
                y1 = double.Parse(y1Box.Text);
                x2 = double.Parse(x2Box.Text);
                y2 = double.Parse(y2Box.Text);
                x3 = double.Parse(x3Box.Text);
                y3 = double.Parse(y3Box.Text);
                isRight = true;
                /*   isRight се ползва после в метода refreshing, за да се провери
                 дали са въведени само числа и да покаже или скрие бутона са намиране
                 на най-ниската точка. */
            }
            catch (FormatException)
            {
                errorLab.Text = "Грешно въведени данни";
                isRight = false;
            }
            finally
            {
                refreshing();
            }
        }

        /* Чрез метода refreshing се появява или скрива бутона за намиране на най-ниската точка. */
        void refreshing()
        {
            if (isRight)
            {
                findPointB.Visible = true;
                errorLab.Text = "";

            }
            else
            {
                findPointB.Visible = false;
            }
        }
    }
}
