
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Program
    {

        enum MenuEntry {Add, Subtract, Multiply, Divide, ProgramEnd};

        static float GetInput(string operand_name)
        {
            Console.Write("Provide operand " + operand_name + ": ");
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
                Console.WriteLine("Menu: \n 1- Add, \n 2- Subtract, \n 3- Multiply, \n 4- Divide, \n 5- Program end\n");
                int input;

                Console.Write("Choose: ");

                if (!int.TryParse(Console.ReadLine(), out input)) {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                };

                MenuEntry current_entry = (MenuEntry)input - 1;

                float operand_a = 0;
                float operand_b = 0;

                switch (current_entry)
                {
                    case MenuEntry.Add:
                        {
                            GetOperands(out operand_a, out operand_b);
                            Console.WriteLine(operand_a + operand_b);
                            break;
                        }
                    case MenuEntry.Subtract:
                        {
                            GetOperands(out operand_a, out operand_b);
                            Console.WriteLine(operand_a + operand_b);
                            break;
                        }
                    case MenuEntry.Multiply:
                        {
                            GetOperands(out operand_a, out operand_b);
                            Console.WriteLine(operand_a * operand_b);
                            break;
                        }
                    case MenuEntry.Divide:
                        {
                            GetOperands(out operand_a, out operand_b);
                            if (operand_b == 0) { Console.WriteLine("Division by 0. Error!"); break; }
                            Console.WriteLine(operand_a / operand_b);
                            break;
                        }
                    case MenuEntry.ProgramEnd:
                        {
                            Console.WriteLine("Program will be terminated.");
                            app_exit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu entry. Try again");
                            break;
                        }

                }
            }

        }
    }
}
