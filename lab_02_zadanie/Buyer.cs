using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_zadanie
{
    class Buyer : Person
    {
        protected List<Product> tasks;

        public Buyer(string name, int age):base(name, age)
        {
            tasks = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }

        public void RemoveProduct(int index)
        {
            if(index<tasks.Count)
            {

            }
        }
    }
}
