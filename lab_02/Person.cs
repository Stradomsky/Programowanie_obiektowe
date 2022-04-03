using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    class Person : IEquatable<Person>
    {
        protected string name;
        protected int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(string PersonName, int PersonAge)
        {
            Name = PersonName;
            Age = PersonAge;
        }

        public override string ToString()
        {
            return "";
        }
                
        public bool Equals(Person other)
        {
            if (other == null) return false;
            return other.Name == Name && other.Age == Age;
        }
    }
}