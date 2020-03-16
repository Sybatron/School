using System;

namespace ConsoleFormP2_12
{

    class ConsoleFormP2_12
    {

        /*Метод за извеждане на корените*/
        static void IzvKor(double num1, double num2)
        {
            double x1, x2, x3, x4;/*Променливи за корените*/
            if (num2 < 0 && num1 < 0)
            {
                Console.WriteLine("Няма реални корени...");
            }
            else
            {
                Console.Write("Корени на уравнението са: ");
            }
            if(num1>=0)
            {
                x1 = Math.Sqrt(num1);
                x2 = -(Math.Sqrt(num1));
                Console.Write("{0} {1} ", Math.Round(x1, 2), Math.Round(x2, 2));
            }
            if (num2 >= 0)
            {
                x3 = Math.Sqrt(num2);
                x4 = -(Math.Sqrt(num2));
                Console.Write("{0} {1}", Math.Round(x3, 2), Math.Round(x4, 2));
            }
            Console.WriteLine("\n");
        } 

        static void Main(string[] args)
        {
            /*Дефиниране на променливите*/
            double a, b, c, D;/*Променливи за a,b,c и дискриминантата*/
            double x1_2, x2_2;
            bool isRight = true;
            /*Извеждане на основния вид на биквадратното уравнение*/
            Console.WriteLine("Основния вид на биквадратното уравние е:.......\nax^4 + bx^2 + c = 0");
            /*Цикъл, който предотвратява грешки в програмата и подтиква към въвеждане на правилни данни. От този цикъл
             може да се излезе, само ако са въведени единствено числа*/
            while (true)
            {
                try
                {
                    Console.Write("Въведете а: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Въведете b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Въведете c: ");
                    c = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Грешно въведени данни, опитайте отново.....\n");
                    isRight = false;
                    a = 0;
                    b = 0;
                    c = 0;
                }
                if (!isRight)
                {
                    isRight = true;
                }
                else
                {
                    break;
                }
            }

            /*Пресмятане на биквадратните корени и дали има решение самото биквадратно уравнение*/
            D = b * b - 4 * a * c;/*Пресмятане на дискриминантата*/
            if (D == 0)
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
                Console.WriteLine("Няма реални корени...\n");
            }

            /*Край на програмата*/
            Console.Write("Натиснете клавиш.....");
            Console.ReadKey();
        }
    }
}
