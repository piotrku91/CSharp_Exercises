
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_2
{
    class Program
    {

        static void Main(string[] args)
        {
            const int array_size = 3;
            float[] input = new float[array_size];

            Console.WriteLine("Podaj liczbę a: ");
            bool validation = float.TryParse(Console.ReadLine(), out input[0]);

            Console.WriteLine("Podaj liczbę b: ");
            validation = validation && float.TryParse(Console.ReadLine(), out input[1]);

            Console.WriteLine("Podaj liczbę c: ");
            validation = validation && float.TryParse(Console.ReadLine(), out input[2]);

            if (validation)
            {
                string score_string = "";

                if (input[1] < input[0] && input[2] < input[0])
                {
                    if (input[1] > input[2])
                    {
                        score_string += input[2] + " ";
                        score_string += input[1] + " ";
                        score_string += input[0] + " ";
                    }
                    else
                    {
                        score_string += input[1] + " ";
                        score_string += input[2] + " ";
                        score_string += input[0] + " ";
                    }

                }
                else if (input[0] < input[1] && input[2] < input[1])
                {
                    if (input[1] > input[2])
                    {
                        score_string += input[2] + " ";
                        score_string += input[0] + " ";
                        score_string += input[1] + " ";
                    }
                    else
                    {
                        score_string += input[0] + " ";
                        score_string += input[2] + " ";
                        score_string += input[1] + " ";
                    }
                }
                else if (input[0] < input[2] && input[1] < input[2])
                {
                    if (input[0] > input[1])
                    {
                        score_string += input[1] + " ";
                        score_string += input[0] + " ";
                        score_string += input[2] + " ";
                    }
                    else
                    {
                        score_string += input[1] + " ";
                        score_string += input[2] + " ";
                        score_string += input[3] + " ";
                    }
                }
                Console.WriteLine(score_string);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }
        }
    }
}