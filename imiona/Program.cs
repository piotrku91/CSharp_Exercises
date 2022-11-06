
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imiona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile chcesz wpisać imion?");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] imiona = new string[size];

            for(int i = 0; i < imiona.Length; i++)
            {
                Console.WriteLine("Podaj imie: ");
                imiona[i] = Convert.ToString(Console.ReadLine());
            }

            foreach(ref string i in imiona)
            {
                Console.Write(i);
                i = "eee";
            }
            Console.Write("\n");
        }
    }
}
