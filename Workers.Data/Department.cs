using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers.Data
{
    public class Department : IEquatable<Department>
    {
        public string NameDepartment { get; set; }

        public Department(string name)
        {
            NameDepartment = name;
        }

        public bool Equals(Department other)
        {
            return this.NameDepartment == other.NameDepartment;
        }
    }
}
