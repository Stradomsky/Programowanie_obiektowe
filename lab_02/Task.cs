using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    class Task:IEquatable<Task>
    {
        private string name;
        private TaskStatus status;

        public string Name { get => name; set => name = value; }
        public TaskStatus Status { get => status; set => status = value; }

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public override string ToString()
        {
            return $"Nazwa Zadania: {name} Status: {status.ToString()}";
        }

        public bool Equals(Task other)
        {
            if (this.name == other.name &&
                this.Status == other.Status)
                return true;

            return false;
        }
    }
}