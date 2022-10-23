using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_3
{
    class Program
    {

        static int CountElementInArray(int[] array, int array_size, int element)
        {
            int count = 0;

            for (int i = 0; i < array_size; i++)
            {
                if (element == array[i])
                {
                    count++;
                }
            }
            return count;
        }
        static string GetNumberInCharStyle(int number, char target_char)
        {
            string output = "";
            for (int i = 0; i < number; i++)
            {
                output += target_char;
            }
            return output;
        }
        static void Main(string[] args)
        {
            const int min_range = 1;
            const int max_range = 5;

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
                Console.WriteLine("Podaj liczbę {0} (przedział <{1},{2}>: ", i, min_range, max_range);
                validation = validation && int.TryParse(Console.ReadLine(), out input[i]);

                if (!validation) { break; };
            }

            Console.Write("\n");

            if (validation)
            {
                for(int i = min_range; i <= max_range; i++)
                {
                    int count = CountElementInArray(input, max_count, i);
                    Console.WriteLine(i + ": " + GetNumberInCharStyle(count, '*')); ;
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
