using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleP3_22
{
    class Program
    {
        static ulong NOD(ulong a1, ulong b1)
        {
            while (a1 != b1)
            {
                if (a1 >= b1) a1 -= b1;
                else b1 -= a1;
            }
            return a1;
        }
        static ulong NOK(ulong a1, ulong b1)
        {
            return a1 / NOD(a1, b1) * b1;
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете n: ");
            uint n = uint.Parse(Console.ReadLine());
            ulong a=1 , b=n, i;
            if (n != 1)
            {
                for (i = n; i >= 2; i--)
                {
                    a = a + (i-1)/NOD(b, i - 1);
                    b = NOK(b, i - 1);
                    
                }
            }
            ulong c = NOD(b, a);
            a /= c;
            b /= c;
            Console.WriteLine("Сумата на първите {0} елемента на хармоничната редица е:" +
                "\n{1}\n-\n{2}",n,a,b);
            Console.Write("Натиснете клавиш.....");
            Console.ReadKey();
        }
    }
}
