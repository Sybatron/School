using System;

namespace ConsoleP3_24
{
    class P3_24
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n!!: ");
            uint n = uint.Parse(Console.ReadLine());
            ulong multiply = 1;
            if (n != 0)
            {
                if (n % 2 == 0)
                {
                    for (uint i = 2; i <= n; i += 2)
                    {
                        multiply *= i;
                    }
                }
                else for (uint i = 1; i <= n; i += 2)
                    {
                        multiply *= i;
                    }
            }
            else multiply = 0;
            Console.WriteLine("{0}!! ({0} двоен факториел) е: {1}", n, multiply);
            Console.Write("Натиснете клавиш.....");
            Console.ReadKey();
        }
    }
}
