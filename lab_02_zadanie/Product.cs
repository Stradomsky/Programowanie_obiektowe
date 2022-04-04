using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_zadanie
{
    class Product : IThing
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Product (string name)
        {
            this.name = name;
        }

        public virtual void Print (string prefix)
        {
            Console.Write($"{prefix}{name}");
        }
    }
}
