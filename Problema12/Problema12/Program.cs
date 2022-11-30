using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinati cate numere intregi divizibile cu n se afla " +
                              "in intervalul [a, b].");
            int a, b, n;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            n = int.Parse(t[2]);
            int nr = 0;
            for (int i = a; i <= b; i++)
                if (n % i == 0) nr++;
            Console.WriteLine("In intervalul [{0}, {1}] se afla" + " " + nr + " "  + "numere intregi divizibile cu {2}", a, b, n);
            Console.ReadKey();
        }
    }
}
