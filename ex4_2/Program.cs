
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_2
{
    class Program
    {
        static void DisplayArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0} ", array[i]);
            }
        }

        static void FillArrayByRandomNumbers(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            };
        }

         static void FillArrayByOrder(int[] array, int begin)
        {
            int current_number = begin;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = current_number++;
            };
        }

        static int FindNumbersFromRange(int[] base_array_to_search, int a, int b)
        {
            int found = 0;
            for (int i = 0; i < base_array_to_search.Length; i++)
            {
                    if (base_array_to_search[i] == range_to_find[j])
                    {
                        found++;
                    }
                }

            }
            return found;
        }

        static bool GetInput(string operand_name, ref int value)
        {
            Console.Write("Podaj " + operand_name + ": ");
            return int.TryParse(Console.ReadLine(), out value);
        }
        static bool GetOperands(ref int operand_a, ref int operand_b)
        {
            bool success = GetInput("Początek przedziału", ref operand_a);
            success = success && GetInput("Koniec przedziału", ref operand_b);
            return success;
        }

        static void Main(string[] args)
        {
            int begin = 0;
            int end = 0;

            int[] randomized_array = new int[100];
            

            if (GetOperands(ref begin, ref end))
            {
                int[] search_numbers_array = new int[(end - begin) + 1];
                Console.WriteLine("Losowane liczby: ");
                FillArrayByRandomNumbers(randomized_array);
                DisplayArray(randomized_array);
                Console.WriteLine("\nSzukane liczby: ");
                FillArrayByOrder(search_numbers_array, begin); 
                DisplayArray(search_numbers_array);
                int found_numbers_count = FindNumbersFromRange(randomized_array, search_numbers_array);
                Console.WriteLine("\nZnaleziono: ", found_numbers_count);


            }
            else
            {
                Console.WriteLine("Zła składnia");
            }

        }
    }
}
