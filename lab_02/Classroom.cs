using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    class Classroom
    {
        private string name;
        private Person[] people;
        public string Name { get => name; set => name = value; }
        public Classroom(string name, Person[] people)
        {
            this.name = name;
            this.people = people;
        }

        public override string ToString()
        {
            string results = $"Classroom: {name}\n";

            for (int i = 0; i < people.Length; i++)
            {
                results += $"{people[i]}\n";
            }

            return results;
        }
    }
}
