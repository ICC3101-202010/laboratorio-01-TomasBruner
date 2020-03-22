using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random lanzar = new Random();

            Console.WriteLine("cachipun " + lanzar.Next(0, 3));
            Console.ReadKey();
        }
    }
}
