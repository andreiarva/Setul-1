using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se dau doua variabile numerice a si b ale carori valori sunt date de intrare." +
                " Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  ");
            int a, b;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            Console.WriteLine("Inainte : a = {0} si b = {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Dupa : a = {0} si b = {1}", a, b);
            Console.ReadKey();
        }
    }
}
