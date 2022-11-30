using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    internal class Program
    {
        public static int K { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar. " +
                              "Cifrele se numara de la dreapta la stanga.");
            int  k;
            string[] t = Console.ReadLine().Split(' ');
           string n = t[0];
            k = int.Parse(t[1]);
            Console.WriteLine(n[n.Length - k]);
            Console.ReadKey();
        }
    }
}
