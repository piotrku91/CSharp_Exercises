namespace ConsoleApp5
{
    internal class Program
    {

        static int CountTax(int income)
        {
            int level = 120000;
            if (income < level)
            {
                return 17 * income / 100;
            }
            return 20400 + (income - level);
        }


        static void Main(string[] args)
        {
            int Income = int.Parse(Console.ReadLine());
            Console.WriteLine("Podatek: " + CountTax(Income));

        }
    }
}