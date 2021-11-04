using System;
using System.Collections.Generic;
using System.Text;

namespace employees
{
    class Employee
    {
        protected string name;
        protected string firstName;
        protected int salary;

        public Employee()
        {
            name = "";
            firstName = "";
            salary = 0;
        }
        public Employee(string name, string firstName, int salary)
        {
            this.name = name;
            this.firstName = firstName;
            this.salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{name} is working.");
        }

        public virtual void Stop()
        {

        }
    }
}
