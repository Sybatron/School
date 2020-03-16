using System;

namespace ConsoleForm_P2_41
{
    class Program
    {
        static double x1, y1, x2, y2, x3, y3;/*Променливи за кординатите на точките*/
        static bool isRight = false;

        static void Main(string[] args)
        {
            /* Безкраен цикъл, от който може да се излезе само ако са въведени числа. */
            while (true)
            {
                /*Вика се мотода Vavedi за въвеждане на кординатите*/
                new Program().Vavedi();
                if (isRight)/*Ако са въведени само числа се излиза от цикъла*/
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Грешно въведени задачи...");
                    /*Ако не са въведени само числа се извежда съобщение за грешка*/
                }
            }

            double lowest = Math.Min(y1, y2);
            lowest = Math.Min(lowest, y3);/*Намиране на най-ниската точка*/
            /* Търси се съвпадение с някои от кординатите и след това извежда кординатите на най-ниската точка*/
            if (lowest == y1)
            {
                Console.WriteLine("Кординатите на точката, която е най-ниска са: x = {0}; y = {1}",x1,y1);
            }
            else if (lowest == y2)
            {
                Console.WriteLine("Кординатите на точката, която е най-ниска са: x = {0}; y = {1}", x2, y2);
            }
            else
            {
                Console.WriteLine("Кординатите на точката, която е най-ниска са: x = {0}; y = {1}", x3, y3);
            }
            Console.Write("Натиснете клавиш.....");
            Console.ReadKey();
        }

        void Vavedi()
        {
            /*Въвеждат се кординатите на трите точки*/
            try
            {
                Console.Write("Въведете x кордината на първата точка: ");
                x1 = double.Parse(Console.ReadLine());
                Console.Write("Въведете y кордината на първата точка: ");
                y1 = double.Parse(Console.ReadLine());

                Console.Write("Въведете x кордината на втората точка: ");
                x2 = double.Parse(Console.ReadLine());
                Console.Write("Въведете y кордината на втората точка: ");
                y2 = double.Parse(Console.ReadLine());

                Console.Write("Въведете x кордината на третата точка: ");
                x3 = double.Parse(Console.ReadLine());
                Console.Write("Въведете y кордината на третата точка: ");
                y3 = double.Parse(Console.ReadLine());

                isRight = true;/*Променлива за проверка дали са въведени само числа*/
            }
            catch (FormatException)
            {
                isRight = false;
            }
        }
    }
}
