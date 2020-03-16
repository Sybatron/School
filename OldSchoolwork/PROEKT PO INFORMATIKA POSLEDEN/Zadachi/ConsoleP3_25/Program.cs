using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleP3_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишете А или Б за това коя подточка искате: ");
            char letter = char.Parse(Console.ReadLine());
            if(letter=='А' || letter == 'a')
            {
                for(int i=1;i<=40;i++)
                {
                    Console.WriteLine("{0}\"={1}см",i,i*2.54);
                }
            }
            else if(letter == 'Б' || letter == 'б')
            {
                int m, n;
                Console.WriteLine("Ще бъде отпечатана таблица в диапазона M\"-N\"");
                Console.Write("Въведете M\": ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Въведете N\": ");
                n = int.Parse(Console.ReadLine());
                for (int i = m; i <= n; i++)
                {
                    Console.WriteLine("{0}\"={1}см", i, i * 2.54);
                }
            }
            Console.Write("Натиснете клавиш.....");
            Console.ReadKey();
        }
    }
}
