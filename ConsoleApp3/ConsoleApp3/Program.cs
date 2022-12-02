namespace ConsoleApp3;

internal class Program
{

    static int CalcByIteration(int n)
    {
       int an_value = 0;
       int an_two_value = 1;
       int an_one_value = -2;

        if (n == 0)
            return an_two_value;

        if (n == 1)
            return an_two_value;

        for (int i = 2; i <= n; i++)
        {
            an_value = -3 * an_one_value + 4 * an_two_value;
            an_two_value = an_one_value;
            an_one_value = an_value;
        }

        return an_value;
    }

    static int CalcByRecurrency(int n)
    {
        if (n == 0)
            return 1;
        if (n == 1)
            return -2;

        return -3*(n-1)+4*(n-2);
    }


    static void Main(string[] args)
    {
        Console.Write("Podaj numer wyrazu ciągu: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("N-ty wyraz ciągu iteracyjny = {0}", CalcByIteration(n));
        Console.WriteLine("N-ty wyraz ciągu rekurencyjny = {0}", CalcByRecurrency(n));
    }
}