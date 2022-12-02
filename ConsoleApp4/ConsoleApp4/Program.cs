namespace ConsoleApp4
{
    internal class Program
    {

        static int LucasNumberCountR(int n)
        {
            if (n == 0) { return 2; };
            if (n == 1) { return 1; };
            return LucasNumberCountR(n - 1) + LucasNumberCountR(n - 2);
        }

        static int LucasNumberCountI(int n)
        {
            int first = 2;
            int second = 1;

            if (n == 0) { return first; };

            int score = 0;

            for (int i = 2; i <= n; i++)
            {
                score = first + second;
                first = second;
                second = score;
            }

            return score;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Jaka liczba:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(LucasNumberCountR(number));
            Console.WriteLine(LucasNumberCountI(number));
        }
    }
}