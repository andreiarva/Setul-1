using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Afisati toti divizorii numarului n. ");
            int n = int.Parse(Console.ReadLine());
            for ( int i = 1; i <= n; i++ )
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            Console.ReadKey();
            
        }
    }
}
