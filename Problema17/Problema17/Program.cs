using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. " +
                "Folositi algoritmul lui Euclid. ");
            string[] t = Console.ReadLine().Split(' ');
           int a = int.Parse(t[0]);
           int b = int.Parse(t[1]);
            int x = a, y = b;
            while( x != 0)
            {
                int r = y % x;
                y = x;
                x = r;
            }
            Console.WriteLine("Cel mai mare divizor comun este" + " " + y);
            Console.WriteLine("Cel mai mic multiplu comun este" + " " + (a * b) / y);
            Console.ReadKey();


        }
    }
}
