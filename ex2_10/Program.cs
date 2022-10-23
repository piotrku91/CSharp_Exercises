using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_10
{
    class Program
    {
        static void DrawTree(uint height)
        {
            uint stars_to_draw = 2 * height - 1;
            for (uint lines = 0; lines < height; lines++)
            {
                for (uint columns = 0; columns < stars_to_draw; columns++)
                {
                    Console.Write("*");
                }
                stars_to_draw -= 2;
                Console.Write("\n");
            }
        }
         static void Main(string[] args)
        {
            uint input_a = 0;
            Console.Write("Podaj wysokość choinki: ");

            if (uint.TryParse(Console.ReadLine(), out input_a))
            {
                DrawTree(input_a);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }

            Console.ReadKey();
        }
    }
}
