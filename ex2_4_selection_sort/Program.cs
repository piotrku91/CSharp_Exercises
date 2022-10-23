
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_2
{
    class Program
    {
        static void swap_values(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        static void selection_sort(ref int[] array, int array_size)
        {
            for (int i = 0; i < array_size - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < array_size; j++)
                {
                    if (array[j] < array[min_index])
                    {
                        min_index = j;
                    }

                    if (min_index != i)
                    {
                        swap_values(ref array[i], ref array[min_index]);
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            const int array_size = 3;
            int[] input = new int[array_size];

            bool validation = true;

            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine("Podaj liczbę {0}: ", i);
                validation = validation && int.TryParse(Console.ReadLine(), out input[i]);
            }

            Console.Write("\n");

            if (validation)
            {
                selection_sort(ref input, array_size);

                for (int i = 0; i < array_size; i++)
                {
                    Console.WriteLine(input[i]);
                }
            }

            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }
        }
    }
}