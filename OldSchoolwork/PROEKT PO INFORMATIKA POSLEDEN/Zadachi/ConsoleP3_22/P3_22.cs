using System;

namespace ConsoleP3_22
{
    class P3_22
    {
        static void Main(string[] args)
        {
            /*Въвеждаме N, което е броят на елемнтите в хармоничната редица*/
            Console.Write("Въведете n: ");
            int N = int.Parse(Console.ReadLine());
            double a = 0;/*Променлива за сбора*/
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
            a = Math.Round(a, 2);/*Накрая закръгляме дробта*/
            /*И извеждаме сумата на първите N елемента в хармоничната редица*/
            Console.WriteLine("Сумата на първите {0} елемента на хармоничната редица е: {1}", N, a);
            Console.Write("Натиснете клавиш.....");
            Console.ReadKey();
        }
    }
}
