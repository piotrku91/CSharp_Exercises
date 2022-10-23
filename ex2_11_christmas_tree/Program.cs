using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choinka
{
    class Program
    {

        static void DrawTree(uint lines)
        {
            uint spaces_needed = lines - 1;
            for (uint line_counter = 1; line_counter <= lines; line_counter++)
            {

                for (uint spaces_counter = 1; spaces_counter <= spaces_needed; spaces_counter++)
                {
                    Console.Write(" ");
                }

                uint stars_needed = 2 * line_counter - 1;
                for (uint star_counter = 1; star_counter <= stars_needed; star_counter++)
                {
                    Console.Write("*");
                }
                spaces_needed--;
                Console.Write("\n");
            }

        }


        static void Main(string[] args)
        {

            uint lines = 0;

            Console.Write("Podaj wysokość choinki:  ");
            if (uint.TryParse(Console.ReadLine(), out lines))
            {
                DrawTree(lines);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }

            Console.ReadKey();
        }
    }
}
