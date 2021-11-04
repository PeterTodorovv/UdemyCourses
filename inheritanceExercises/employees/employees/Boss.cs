using System;
using System.Collections.Generic;
using System.Text;

namespace employees
{
    class Boss :Employee
    {
        string companyCar;

        public Boss() { }

        public Boss(string name, string firstName, int salary, string companyCar)
        {
            this.name = name;
            this.firstName = firstName;
            this.salary = salary;
            this.companyCar = companyCar;
        }

         public virtual void Lead()
        {
            Console.WriteLine($"{name} is leading the company!");
        }
    }
}
