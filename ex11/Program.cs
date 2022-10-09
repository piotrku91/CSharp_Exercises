using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Size definition
            const int width = 3;
            const int height = 3;

            string[,] cells = new string[height, width];

            Console.WriteLine("Witaj w programie Kółko i Krzyżyk!");

            // Getting data from user
            for (int i=0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bool valid_value = false;
                    while (!valid_value)
                    {
                        Console.Write("Podaj stan " + ((i * width + j) + 1) + "-ego pola: ");
                        string new_value = Console.ReadLine();

                        if (new_value == "O" || new_value == "X" || new_value == " ")
                        {
                            cells[i, j] = new_value;
                            valid_value = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid value. Try again.");
                        }
                    }
                }
            }

            Console.Write("\n\n"); // Some dummy line

            // Print matrix
            for (int i = 0; i < height; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < width; j++)
                {
                    Console.Write(cells[i , j]);
                    if (j != width - 1)
                    {
                        Console.Write(" | ");
                    };
                }
                Console.Write("\n");
                if (i != height - 1)
                {
                    for (int k = 0; k < width; k++)
                    {
                        string line_pattern = "---";
                        char joint_char = '+';
                        if (k == width - 1)
                        {
                            Console.Write(line_pattern);
                        }
                        else
                        {
                            Console.Write(line_pattern + joint_char);
                        };
                    }
                };
                Console.Write("\n");
            }
            Console.ReadKey(); 
        }
    }
}
