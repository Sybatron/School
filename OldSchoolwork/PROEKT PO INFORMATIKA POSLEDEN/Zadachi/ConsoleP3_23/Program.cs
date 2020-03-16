using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleP3_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n!: ");
            uint n = uint.Parse(Console.ReadLine());
            ulong multiply=1;
            for(uint i=1;i<=n;i++)
            {
                multiply *= i;
            }
            Console.WriteLine("{0}! ({0} факториел) е: {1}",n,multiply);
            Console.Write("Натиснете клавиш.....");
            Console.ReadKey();
        }
    }
}
