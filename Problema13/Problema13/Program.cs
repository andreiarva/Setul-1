using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determianti cati ani bisecti sunt intre anii y1 si y2");
            int y1, y2;
            string[] t = Console.ReadLine().Split(' ');
            y1 = int.Parse(t[0]);
            y2 = int.Parse(t[1]);
            int nr = 0;
            for (int i = y1 - 1; i < y2; i++)
                if (i % 400 == 0 || (i % 4 == 0 && i % 100 != 0)) nr++;
            Console.WriteLine("intre anii {0} si {1} sunt " + " " + nr + " " + "ani bisecti", y1, y2);
            Console.ReadKey();
        }
    }
}
