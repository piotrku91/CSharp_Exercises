
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_1
{
    class Program
    {

        static float Add(float first, float second)
        {
            return first + second;
        }

        static float Subtract(float first, float second)
        {
            return first - second;
        }

        static float Multiply(float first, float second)
        {
            return first * second;
        }

        static float Divide(float first, float second)
        {
            return first / second;
        }

         static void DisplayScore(float score)
        {
            Console.WriteLine("Wynik działania to: " + score);
        }

        static float GetInput(string operand_name)
        {
            Console.Write("Podaj operand " + operand_name + ": ");
            return float.Parse(Console.ReadLine());
        }

        static void GetOperands(out float operand_a, out float operand_b)
        {
            operand_a = GetInput("a");
            operand_b = GetInput("b");
        }
        static void Main(string[] args)
        {
            bool app_exit = false;
            while (!app_exit)
            {
                Console.Write("Podaj działanie do wykonania (+, -, *, /): ");

                string operation = Console.ReadLine();
                float operand_a = 0;
                float operand_b = 0;

                switch (operation)
                {
                    case "+":
                        {
                            GetOperands(out operand_a, out operand_b);
                            DisplayScore(Add(operand_a, operand_b));
                            break;
                        }
                    case "-":
                        {
                            GetOperands(out operand_a, out operand_b);
                            DisplayScore(Subtract(operand_a, operand_b));
                            break;
                        }
                    case "*":
                        {
                            GetOperands(out operand_a, out operand_b);
                            DisplayScore(Multiply(operand_a, operand_b));
                            break;
                        }
                    case "/":
                        {
                            GetOperands(out operand_a, out operand_b);
                            if (operand_b == 0) { Console.WriteLine("Dzielenie przez 0! Błąd"); break; }
                            DisplayScore(Divide(operand_a, operand_b));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Zły operator!");
                            break;
                        }

                }

                Console.WriteLine("Czy wprowadzić kolejne liczby?");
                if (Console.ReadLine() == "n") { app_exit = true;};
                }
            }

        }
    }

