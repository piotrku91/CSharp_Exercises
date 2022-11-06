
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_6
{
    class Program
    {

         static int FindSmallest(int[,] matrix)
        {
            int min = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                     if (matrix[i,j] < min)
                {
                    min = matrix[i, j];
                }
                }
            }
            return min;
        }

        static int FindLargest(int[,] matrix)
        {
            int max = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                     if (matrix[i,j] > max)
                {
                    max = matrix[i, j];
                }
                }
            }
            return max;
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
            for (int i = 0; i < matrix.GetLength(1); i++)
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
                Console.WriteLine("Minimalna liczba: " + FindSmallest(matrix));
                Console.WriteLine("Maksymalna liczba: " + FindLargest(matrix));
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }

            Console.ReadKey();
        }
    }
}
