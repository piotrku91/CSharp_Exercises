
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_4
{
    class Program
    {
        static void SwapValues(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        static void SelectionSort(ref int[] array, int array_size)
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
                        SwapValues(ref array[i], ref array[min_index]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int max_count = 0;
            Console.WriteLine("Podaj ilość liczb: ");

            if (!int.TryParse(Console.ReadLine(), out max_count))
            {
                Console.WriteLine("Nieprawidłowa ilość liczb");
                Console.ReadKey();
                return;
            }

            int[] input = new int[max_count];

            bool validation = true;

            for (int i = 0; i < max_count; i++)
            {
                Console.WriteLine("Podaj liczbę {0}: ", i);
                validation = validation && int.TryParse(Console.ReadLine(), out input[i]);
            }
            Console.Write("\n");

            if (validation)
            {
                SelectionSort(ref input, max_count);

                for (int i = 0; i < max_count; i++)
                {
                    Console.WriteLine(input[i]);
                }
            }

            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }
            Console.ReadKey();
        }
    }
}