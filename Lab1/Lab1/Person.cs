using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        private string Name;
        private string LastName;

        public int Lanzar()
        {
            Random rnd = new Random();
            int lanzar = rnd.Next(3);
            return lanzar;
        }

        public Person(string InputName, string InputLastName)
        {
            Name = InputName;
            LastName = InputLastName;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetLastName()
        {
            return LastName;
        }


    }
}
