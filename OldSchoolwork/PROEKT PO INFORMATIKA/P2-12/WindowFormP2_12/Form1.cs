using System;
using System.Windows.Forms;

namespace WindowFormP2_12
{
    public partial class WindowsFormP2_12 : Form
    {
        /*  В началото при стартиране скриваме бутона за намиране на корените(doItB).
          Лейбъла ,за показване на грешка или дали няма реални корени(errorLab), и лейбъла ,
          за показване на това как изглежда биквадратното уравнение(forNowLab), им се премахва текста */
        public WindowsFormP2_12()
        {
            InitializeComponent();
            errorLab.Text = "";
            doItB.Visible = false;
            forNowLab.Text = "";
        }

        double a, b, c;
        bool isRight;

        //При промяна на текстовете се вика метода check, който проверява дали са въведени само числа
        private void aBox_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void bBox_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void cBox_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        /*  При натискане бутона за намиране на корените се намира дискриминантата на биквадратното
          уравнение, после спрямо стойността и се извършват различни пресмятания. Накрая се извиква
          метода IzvKor който пресмята окончателно корените и ги извежда съответно в елементите kor1Lab,
          kor2Lab, kor3Lab, kor4Lab. Ако няма реални корени се извежда "Няма реални корени..." в елемента
          errorLab и се извиква метода NoKor, който премахва текстовете на елементите kor1Lab,
          kor2Lab, kor3Lab, kor4Lab. */
        private void doItB_Click(object sender, EventArgs e)
        {
            double D; /*Дискриминанта*/
            double x1_2, x2_2;
            D = b * b - 4 * a * c;/*Пресмятане на дискриминантата*/
            if (D == 0)/*Зависимост от стойността на дискриминантата се прявят различни действия*/
            {
                x1_2 = (-b) / (2 * a);
                x2_2 = x1_2;
                IzvKor(x1_2, x2_2);
            }
            else if (D > 0)
            {
                x1_2 = (-b + Math.Sqrt(D)) / (2 * a);
                x2_2 = (-b - Math.Sqrt(D)) / (2 * a);
                IzvKor(x1_2, x2_2);
            }
            else
            {
                errorLab.Text = "Няма реални корени...";
                NoKor();/*Метод, който се вика ако няма корени и маха текста в текст боксовете за корените  kor1Lab,
          kor2Lab, kor3Lab, kor4Lab*/
            }
        }

        /*  Като се натисне бутона с надпис изчисти, текстовете на всички текст боксове се изчиства,
         лейбълите за корените се връщат в първоначалното си състояните ,когато е била пусната програмата.
         Лейбъла ,за показване на грешка или дали няма реални корени, и лейбъла ,за показване
         на това как изглежда биквадратното уравнение, им се премахва текста. */
        private void clearB_Click(object sender, EventArgs e)
        {
            aBox.Text = "";
            bBox.Text = "";
            cBox.Text = "";
            kor1Lab.Text = "Корен1";
            kor2Lab.Text = "Корен2";
            kor3Lab.Text = "Корен3";
            kor4Lab.Text = "Корен4";
            forNowLab.Text = "";
            errorLab.Text = "";
        }

        /*  Методът check проверява дали в текствбоксовете са въведени само числа, ако не в errorLab се извежда
         съобщението "Грешно въведени данни", накрая се извиква метода refreshing.
         */
        void check()
        {
            try/*Въвеждат се a, b и c*/
            {
                a = double.Parse(aBox.Text);
                b = double.Parse(bBox.Text);
                c = double.Parse(cBox.Text);
                isRight = true;/*Променлива, която се ползва за проверка дали са въведени само числа*/
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

        /*  Чрез метода refreshing се показва до сега как изглежда биквадратното уравнение. Също показва или скрива
         бутона за намиране на корените. */ 
        void refreshing()
        {
            if (isRight)
            {
                doItB.Visible = true;
                errorLab.Text = "";
                forNowLab.Text = a.ToString() + "*X^4+";

                if (b < 0)
                /*Тук се извежда биквадратното уравнение, което се получило до сега, само
                 ако са въведени само числа за a,b,c*/
                {
                    forNowLab.Text = forNowLab.Text + "(" + b.ToString() + ")*X^2";
                }
                else
                {
                    forNowLab.Text = forNowLab.Text + b.ToString() + "*X^2";
                }

                if (c < 0)
                {
                    forNowLab.Text = forNowLab.Text + c.ToString() + "=0";
                }
                else
                {
                    forNowLab.Text = forNowLab.Text + "+" + c.ToString() + "=0";
                }
            }
            else
            {
                doItB.Visible = false;
            }
        }

        /* С метода IzvKor се извеждат корените. */ 
        void IzvKor(double num1, double num2)
        {
            if (num2 < 0 && num1 < 0)
            {
                errorLab.Text = "Няма реални корени...";
                NoKor();
            }
            if (num1 >= 0)
            {
                    kor1Lab.Text = string.Format((Math.Round(Math.Sqrt(num1), 2)).ToString());
                    kor2Lab.Text = string.Format((Math.Round(-Math.Sqrt(num1), 2)).ToString());
            }
            else
            {
                kor1Lab.Text = "";
                kor2Lab.Text = "";
            }
            if (num2 >= 0)
            {
                    kor3Lab.Text = string.Format((Math.Round(Math.Sqrt(num2), 2)).ToString());
                    kor4Lab.Text = string.Format((Math.Round(-Math.Sqrt(num2), 2)).ToString());
            }
            else
            {
                kor3Lab.Text = "";
                kor4Lab.Text = "";
            }
        }

        void NoKor()/*Когато няма корени се премахва текста в лейбълите за корени*/
        {
            kor1Lab.Text = "";
            kor2Lab.Text = "";
            kor3Lab.Text = "";
            kor4Lab.Text = "";
        }
    }
}
