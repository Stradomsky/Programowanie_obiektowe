using System;
using System.Collections.Generic;


namespace lab_02_zadanie
{
    public class Program
    {
        public static void Main()
        {
            Seller treacher = new Seller("Jan Kowalski", 50);
            IThing t = treacher;

            Buyer buyer1 = new Buyer("Jaś Fasola 1", 25);
            Buyer buyer2 = new Buyer("Jaś Fasola 2", 21);
            Buyer buyer3 = new Buyer("Jaś Fasola 3", 23);

            buyer1.AddProduct(new Fruit("Apple", 6));
            buyer1.AddProduct(new Meat("Fish", 0.5));

            Person[] persons = { treacher, buyer1, buyer2, buyer3 };

            Product[] products = {
                new Fruit("Apple", 1000),
                new Fruit("Banana", 700),
                new Fruit("Orange", 500),
                new Meat("Fish", 100.0),
                new Meat("Beef", 75.0)
            };

            Shop shop = new Shop("Super Market", persons, products);

            shop.Print();
        }

        interface IThing
        {
            string Name { get; set; }
        }
        
        class Product : IThing
        {
            private string name;
            public string Name { get => name; set => name = value; }

            public Product(string name)
            {
                this.name = name;
            }

            public virtual void Print(string prefix)
            {
                Console.Write($"{prefix}{name}");

            }
        }
        class Fruit : Product
        {
            private int count;
            public int Count { get => count; set => count = value; }

            public Fruit(string name, int count) : base(name)
            {
                this.Count = count;
            }

            public override void Print(string prefix)
            {
                base.Print(prefix);
                Console.Write($"{prefix}({count} fruits)\n");
            }
        }
        
        class Meat : Product
        {
            private double weight;
            public double Weight { get => weight; set => weight = value; }

            public Meat(string name, double weight) : base(name)
            {
                this.weight = weight;
            }

            public override void Print(string prefix)
            {

                base.Print(prefix);
                Console.Write($"{prefix}({weight} kg)\n");
            }
        }
        
        class Person : IThing
        {
            private string name;
            private int age;

            public string Name { get => name; set => name = value; }

            public int Age { get => age; set => age = value; }


            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public virtual void Print(string prefix)
            {
                Console.Write($"{name} ({age} y.o.)\n");
            }
        }
        class Buyer : Person
        {
            protected List<Product> tasks;


            public Buyer(string name, int age) : base(name, age)
            {
                tasks = new List<Product>();
            }

            public void AddProduct(Product product)
            {
                tasks.Add(product);
            }

            public void RemoveProduct(int index)
            {
                if (index < tasks.Count)
                {
                    tasks.RemoveAt(index);
                }
            }

            public override void Print(string prefix)
            {
                Console.Write($"{prefix}Buyer: ");
                base.Print(prefix);

                if (tasks.Count > 0)
                {
                    Console.WriteLine($"{prefix}{prefix}-- Products: --");
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.Write(prefix);
                        tasks[i].Print("\t");
                    }
                }

            }
        }
        class Seller : Person
        {
            public Seller(string name, int age) : base(name, age) { }

            public override void Print(string prefix)
            {
                Console.Write($"{prefix}Seller: ");
                base.Print(prefix);
            }

        }
        class Shop : IThing
        {
            private string name;
            private Person[] people;
            private Product[] products;
            public string Name { get => name; set => name = value; }

            public Shop(string name, Person[] people, Product[] products)
            {
                this.name = name;
                this.people = people;
                this.products = products;
            }

            public void Print()
            {
                Console.WriteLine($"Shop: {name} ");
                Console.WriteLine("-- People: --");

                for (int i = 0; i < people.Length; i++)
                {
                    people[i].Print("\t");
                }
                Console.WriteLine("-- Products: --");

                for (int i = 0; i < products.Length; i++)
                {
                    products[i].Print("\t");
                }

            }
        }

    }
}