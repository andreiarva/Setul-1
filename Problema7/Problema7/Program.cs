using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se dau doua variabile numerice a si b ale carori valori sunt date de intrare." +
                               "Se cere sa se inverseze valorile lor. ");
            int a, b;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            Console.WriteLine("Inainte : a = {0}, b = {1}", a, b);
            int aux = a;
            a = b;
            b = aux;
            Console.WriteLine("Dupa : a = {0}, b = {1}", a, b);
            Console.ReadKey();
        }
    }
}
