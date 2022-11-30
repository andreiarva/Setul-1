using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ");
            string[] t = Console.ReadLine().Split(' ');
            int b = int.Parse(t[0]);
            int a = int.Parse(t[1]);
            int x = -(b / a);
            Console.WriteLine("x =" + " " + x);
            Console.ReadKey();

        }
    }
}
