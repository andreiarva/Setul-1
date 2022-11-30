using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detreminati daca un an y este an bisect. ");
            int y = int.Parse(Console.ReadLine());
            if((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
            {
                Console.Write("Anul {0} este an bisect", y);
            }
            else
            {
                Console.Write("Anul {0} nu este an bisect", y);
            }
            Console.ReadKey();
        }
    }
}
