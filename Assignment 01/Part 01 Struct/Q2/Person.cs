using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01.Part_01.Q2
{
    internal struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }
    }
}
