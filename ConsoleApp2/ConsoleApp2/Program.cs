namespace ConsoleApp2
{
    internal class Program
    {
        static int NWDR(int a, int b)
        {
            if (a == b) { return a; };
            if (a > b)
            {
                return NWDR(a - b, b);
            }
            return NWDR(b - a, a);

        }

        static int NWDI(int a, int b)
        {
            int lhs = a;
            int rhs = b;

            while (lhs != rhs)
            {
                if (lhs > rhs)
                {
                    lhs = lhs - rhs;
                }
                else
                {
                    rhs = rhs - lhs;
                }
            }
            return rhs;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("NWD REKURENCJA: " + NWDR(a, b));
            Console.WriteLine("NWD ITERACJA: " + NWDI(a, b));
        }
    }
}