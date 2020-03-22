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
            Person p1 = new Person();

            Console.WriteLine(p1.Lanzar());
            Console.WriteLine(p1.Name + " " + p1.LastName);
            Console.ReadKey();
        }
    }
}
