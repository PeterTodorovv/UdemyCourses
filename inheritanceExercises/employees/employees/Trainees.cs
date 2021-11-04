using System;
using System.Collections.Generic;
using System.Text;

namespace employees
{
    class Trainees :Employee
    {
        public int workingHours;
        public int schoolHours;

        public Trainees() { }

        public Trainees(string name, string firstName, int salary, int workingHours, int schoolHours)
        {
            this.name = name;
            this.firstName = firstName;
            this.salary = salary;
            this.workingHours = workingHours;
            this.schoolHours = schoolHours;
        }

        public override void Work()
        {
            Console.WriteLine($"{name} is workoing {workingHours} a day.");
        }
    }
}
