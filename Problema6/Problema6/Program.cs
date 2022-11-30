using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
            int a, b, c;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            c = int.Parse(t[2]);
            if( a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("{0}, {1} si {2} pot fi lungimile laturilor unui triunghi", a, b, c);
            }
            else
            {
                Console.WriteLine("{0}, {1} si {2} nu pot fi lungimile laturilor unui triunghi", a, b, c);
            }
            Console.ReadKey();
        }
    }
}
