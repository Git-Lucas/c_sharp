using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesEmployee1
{
    class Employee
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public double Salary { get; private set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
