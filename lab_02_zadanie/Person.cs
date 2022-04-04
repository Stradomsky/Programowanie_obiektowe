using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_zadanie
{
    class Person : IThing
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Print(string prefix)
        {
            Console.Write($"{name} ({age} y.o.)\n");
        }
    }
}
