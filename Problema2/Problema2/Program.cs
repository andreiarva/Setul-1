using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare." +
                              " Tratati toate cazurile posibile. ");
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            int c = int.Parse(t[2]);
            int d = b * b - 4 * a * c;
            if (d > 0)
                Console.WriteLine("x1 = " + ((-b + Math.Sqrt(d)) / (2 * a)) + "\n" +
                                  "x2 = " + ((-b - Math.Sqrt(d)) / (2 * a)));
            else if (d == 0)
                Console.WriteLine(" x = " + ((-b + Math.Sqrt(d)) / (2 * a)));
            else
                Console.WriteLine("Ecuatia nu are solutii reale");
            Console.ReadKey();
        }
    }
}
