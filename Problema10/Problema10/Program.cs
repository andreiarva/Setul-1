using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema10
{
    internal class Program
    {
        public static bool prim(int n)
        {
            if(n < 2)
            {
                return false;
            }
            if(n == 2)
            {
                return true;
            }
            if(n % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i * i <= n; i += 2)
                if ((n % i) == 0)
                    return false;
            return true;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("determinati daca un numar n este prim");
            int n = int.Parse(Console.ReadLine());
            if (prim(n))
                Console.WriteLine("numarul este prim");
            else
                Console.WriteLine("numarl nu este prim");
            Console.ReadKey();
        }
    }
}
