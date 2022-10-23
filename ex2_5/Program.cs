
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_5
{
    class Program
    {

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
                            Console.WriteLine(operand_a + operand_b);
                            break;
                        }
                    case "-":
                        {
                            GetOperands(out operand_a, out operand_b);
                            Console.WriteLine(operand_a + operand_b);
                            break;
                        }
                    case "*":
                        {
                            GetOperands(out operand_a, out operand_b);
                            Console.WriteLine(operand_a * operand_b);
                            break;
                        }
                    case "/":
                        {
                            GetOperands(out operand_a, out operand_b);
                            if (operand_b == 0) { Console.WriteLine("Dzielenie przez 0! Błąd"); break; }
                            Console.WriteLine(operand_a / operand_b);
                            break;
                        }
                    case "koniec":
                        {
                            Console.WriteLine("Koniec programu");
                            app_exit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Zły operator!");
                            break;
                        }

                }
            }

        }
    }
}
