using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_2
{
    class Program
    {

        enum DisplayOrder { Normal, Reversed};
        static void PrintInRow(int[] array, int count, DisplayOrder display_order)
        {
            if (display_order == DisplayOrder.Normal)
            {
                Console.WriteLine("Wiersz: ");
                for (int i = 0; i < count; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Wiersz (odwrócony): ");
                for (int i = count - 1; i >= 0; i--)
                {
                    Console.Write(array[i] + " ");
                }
            }
                Console.Write("\n");
        }

        static void PrintInColumn(int[] array, int count)
        {
            Console.WriteLine("Kolumna: ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int max_count = 0;
            Console.WriteLine("Podaj ilość liczb: ");

            if (!int.TryParse(Console.ReadLine(), out max_count))
                {
                Console.WriteLine("Nieprawidłowa ilość liczb");
                return;
            }

            int[] input = new int[max_count];
            bool validation = true;

            for (int i = 0; i < max_count; i++)
            {
                Console.WriteLine("Podaj liczbę {0}: ", i);
                validation = validation && int.TryParse(Console.ReadLine(), out input[i]);

                if (!validation) { break; };
            }

            Console.Write("\n");

            if (validation)
            {
                PrintInRow(input, max_count, DisplayOrder.Normal);
                PrintInColumn(input, max_count);
                PrintInRow(input, max_count, DisplayOrder.Reversed);
            }

            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }
            Console.ReadKey();
        }
    }
}
