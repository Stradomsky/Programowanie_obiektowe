using System;

namespace lab_02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher("Agnieszka Iksinska", 44);

            Student student1 = new Student("Jan Kowalski", "Lab-01", 20);
            Student student2 = new Student("Ola Michalska", "Lab-01", 19);
            Student student3 = new Student("Kamil Nowak", "Lab-02", 20);

            Student student4 = new Student();

            Console.WriteLine(teacher1);

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);

            Console.WriteLine(student4);
            

        }

        public class Person
        {
            public string name { get; set; }
            public int age { get; set; }

            
            public Person()
            {
                name = "XXX";
                age = 0;
            }

            public override string ToString()
            {
                return "Name: "+ name + " ("+age+")";
            }
        }

        public class Student : Person
        {
            string group { get; set; }

            public Student()
            { }         
            
            public Student(string name1, string group1, int age1)
            {
                name = name1;
                group = group1;
                age = age1;
            }

        }
        public class Teacher: Person
        {
            public Teacher()
            { }
            
            public Teacher(string name1, int age1)
            { 
                name = name1;
                age = age1;
            }
        }

        public class Classroom
        {
            private string name { get; set; }
        }
    }
}
