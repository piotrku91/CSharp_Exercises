using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choinka
{
    class Program
    {

        static void DrawTree(int lines)
        {
            int spaces_needed = lines - 1;
            for (int line_counter = 1; line_counter <= lines; line_counter++)
            {

                for (int spaces_counter = 1; spaces_counter <= spaces_needed; spaces_counter++)
                {
                    Console.Write(" ");
                }

                int stars_needed = 2 * line_counter - 1;
                for (int star_counter = 1; star_counter <= stars_needed; star_counter++)
                {
                    Console.Write("*");
                }
                spaces_needed--;
                Console.Write("\n");
            }
            Console.Write("\n");
        }


        static void Main(string[] args)
        {

            int lines = 0;

            while (true)
            {
                Console.Write("Enter size of tree: ");
                if (int.TryParse(Console.ReadLine(), out lines)) {
                    DrawTree(lines);
                    continue;
                };
                Console.WriteLine("Error input! Try again.");
            }

        
            Console.ReadKey();
        }
    }
}
