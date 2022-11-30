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
            int a, b, x;
            string[] t = Console.ReadLine().Split(' ');
            b = int.Parse(t[0]);
            a = int.Parse(t[1]);
            x = -(b / a);
            Console.Write(x);
            Console.ReadKey();
        }
    }
}
