using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_06
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Mateusz", 20, "Student");

            Console.WriteLine(user);

            //List<User> users = new List<User>()
            //{
            //    new User {Name = "a"},
            //    new User {Name = "b"},
            //    new User {Name = "c"},
            //    new User {Name = "a"}

            //};

            //Console.WriteLine(users.Count());

            //var u = users.Select(u => u.Name).ToList();
            //var u2 = users.OrderBy(u => u.Name);

            //IEnumerable<User> u2_2 = (from user in users orderby user.Name select user).ToList();

            //foreach (User user in u2)
            //{
            //    Console.WriteLine(user.Name);
            //}

        }
        public class User
        {
            public string Name { get; set; }
            public string Role { get; set; } // ADMIN, MODERATOR, TEACHER, STUDENT
            public int Age { get; set; }
            public int[] Marks { get; set; } // zawsze null gdy ADMIN, MODERATOR lub TEACHER
            public DateTime? CreatedAt { get; set; }
            public DateTime? RemovedAt { get; set; }

            public User(string _Name, int _Age, string _Role)
            {
                Name = _Name;
                Age = _Age;
                Role = _Role;
            }

            public override string ToString()
            {
                return $"User: {Name} ({Age} y.o.) - {Role}";
            }
        }

        public class Student:User
        {
            protected List<int> marks;

            public Student(string _Name, int _Age, string _Role) : base(_Name, _Age, _Role)
            {
                marks = new List<int>();
            }

            public void AddMark(int mark)
            {
                marks.Add(mark);
            }
        } 
    }
}
