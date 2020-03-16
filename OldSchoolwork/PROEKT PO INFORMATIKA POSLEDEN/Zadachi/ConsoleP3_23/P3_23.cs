using System;

namespace ConsoleP3_23
{
    class P3_23
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n!: ");
            uint n = uint.Parse(Console.ReadLine());
            ulong multiply=1;
            if (n != 0)
                for (uint i=1;i<=n;i++)
                {
                multiply *= i;
                }
            else multiply = 0;
            Console.WriteLine("{0}! ({0} факториел) е: {1}",n,multiply);
            Console.Write("Натиснете клавиш.....");
            Console.ReadKey();
        }
    }
}
