using System;

namespace lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jan Kowalski", "Lab-01", 20);
            Student student2 = new Student("Ola Michalska", "Lab-01", 19);
            Student student3 = new Student("Kamil Nowak", "Lab-02", 20);

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
            

        }

        public class Student
        {
            string name { get; set; }
            string group { get; set; }
            int age { get; set; }

            public Student(string name1, string group1, int age1)
            {
                name = name1;
                group = group1;
                age = age1;
            }

        }
        public class Teacher
        {
            string name { get; set; }
            int age { get; set; }

            public Teacher(string name1, int age1)
            {
                name = name1;
                age = age1;
            }
        }
    }
}
