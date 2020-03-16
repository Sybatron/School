using System;

namespace GaussMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Въвеждане на данните
            //1.1.Въвеждане броя на неизвестните
            int rows = int.Parse(Console.ReadLine());
            double[,] matrix = new double[rows, rows + 1];
            //1.2.Въвеждане коефициентите пред неизвестните и свободните членове
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            //2.Прав ход – до „триъгълен“ вид на матрицата
            //3.Обратен ход – намиране стойностите на неизвестните
            //4.Извеждане на резултата
        }
    }
}
