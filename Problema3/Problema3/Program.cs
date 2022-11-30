using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
            int n, k;
            string[] t = Console.ReadLine().Split(' ');
            n = int.Parse(t[0]);
            k = int.Parse(t[1]);
            if ( n % k == 0)
            {
                Console.WriteLine("{0} se divide cu {1}", n, k);
            }
            else
            {
                Console.WriteLine("{0} nu se divide cu {1}", n, k);
            }
            Console.ReadKey();
        }
    }
}
