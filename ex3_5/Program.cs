
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_5
{
    class Program
    {

        static int FindSmallest(int[] range)
        {
            int min = range[0];
            for (int i = 0; i < range.Length; i++)
            {
                if (range[i] < min)
                {
                    min = range[i];
                }
            }
            return min;
        }

        static int FindLargest(int[] range)
        {
            int max = range[0];
            for (int i = 0; i < range.Length; i++)
            {
                if (range[i] > max)
                {
                    max = range[i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] members = new int[100];

            for (int i = 0; i < members.Length; i++)
            {
                members[i] = rnd.Next(100);
            };

            Console.WriteLine("Wylosowane liczby to:");
            for(int i = 0; i < members.Length; i++)
            {
                if (i + 1 == members.Length)
                {
                Console.Write("{0}", members[i]);
                } else
                {
                Console.Write("{0}, ", members[i]);
                };
            }
            Console.Write("\n");
            Console.WriteLine("Minimalna liczba: " + FindSmallest(members));
            Console.WriteLine("Maksymalna liczba: " + FindLargest(members));

            Console.ReadKey();

        }
    }
}
