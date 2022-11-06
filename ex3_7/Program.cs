
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_7
{
    class Program
    {

         static int FindAndSumNumbersDividedBy4InParityColumns(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                     if (j % 2 == 0 && matrix[i, j] % 4 == 1)
                {
                    sum += matrix[i, j];
                }
                }
            }
            return sum;
        }

        static void FillMatrixByRandom(int[,] matrix)
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rand.Next(100);
                }
            }
        }

        static void DrawMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("\t"+matrix[i,j] + " ");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            uint input_a = 0;
            uint input_b = 0;

            Console.Write("Podaj wymiar n: ");
            bool validation = uint.TryParse(Console.ReadLine(), out input_a);

            Console.Write("Podaj wymiar m: ");
            validation = validation && uint.TryParse(Console.ReadLine(), out input_b);

            if (validation)
            {
                int[,] matrix = new int[input_a, input_b];
                FillMatrixByRandom(matrix);
                DrawMatrix(matrix);
                Console.WriteLine("Suma: " + FindAndSumNumbersDividedBy4InParityColumns(matrix));
                
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }

            Console.ReadKey();
        }
    }
}
