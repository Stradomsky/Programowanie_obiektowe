using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    class Student : Person, IEquatable<Student>
    {
        protected string group;
        protected List<Task> tasks;
        public string Group { get => group; set => group = value; }

        public Student(string PersonName, int PersonAge, string PersonGroup) : base(PersonName, PersonAge)
        {
            group = PersonGroup;
            tasks = new List<Task>();
        }

        public Student(string PersonName, int PersonAge, string PersonGroup, List<Task> tasks1) : base(PersonName, PersonAge)
        {
            tasks = tasks1;
            tasks = new List<Task>();
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            var task = new Task(taskName, taskStatus);
            tasks.Add(task);
        }
        
        public void RemoveTask(int index)
        {
            if (index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            if (index < tasks.Count)
            {
                tasks[index].Status = taskStatus;
            }
        }

        public string RenderTasks(string prefix = "\t")
        {
            string results = "";
            for (int i = 0; i < tasks.Count; i++)
            {
                results += $"{prefix} {i + 1}. {tasks[i].Name} [{tasks[i].Status}]\n";
            }

            return results;
        }

        public override string ToString()
        {
            return $"Student: {name} ({age} y.o.)\nGroup: {group}\n{RenderTasks()}"; 
        }

        public bool Equals(Student other)
        {
            if (this.name == other.name &&
                this.age == other.age &&
                this.group == other.group &&
                SequenceEqual(this.tasks, other.tasks))
            {
                return true;
            }

            return false;
        }

        public bool SequenceEqual(List<Task> a, List<Task> b)
        {
            if (a.Count != b.Count) return false;

            for (int i = 0; i < a.Count; i++)
            {
                if (!a[i].Equals(b[i]))
                    return false;
            }

            return true;
        }
    }
}
