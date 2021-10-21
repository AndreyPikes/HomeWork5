using System;

namespace Workers.Data
{
    public class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string Comment { get; set; }
        public bool Secrecy { get; set; }
        public Department Department { get; set; } 

        public Worker () { }

        public Worker (string name, int age, string position, string comment, bool secrecy, Department department)
        {
            Name = name;
            Age = age;
            Position = position;
            Comment = comment;
            Secrecy = secrecy;
            Department = department;
        }
    }
}
