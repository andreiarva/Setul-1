using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
            int a, b, c;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            c = int.Parse(t[2]);
            int max = a;
            if(b > max)
                max = b;
            if (c > max)
                max = c;
            int min = a;
            if(b < min)
                min = b;
            if (c < min)
                min = c;
            int med = (a + b + c) - max - min;
            Console.WriteLine(min + " " + med + " " + max);
            Console.ReadKey();


        }
    }
}
