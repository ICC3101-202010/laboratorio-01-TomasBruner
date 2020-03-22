using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        public string Name;
        public string LastName;

        public int Lanzar()
        {
            Random rnd = new Random();
            int lanzar = rnd.Next(3);
            return lanzar;
        }

        public Person()
        {
            this.Name = "Bob";
            this.LastName = "Kunga";
        }


    }
}
