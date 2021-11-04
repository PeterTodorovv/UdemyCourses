using System;

namespace employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Jake = new Employee("Smith", "Jake", 1200);
            Trainees Ivan = new Trainees("Ivnov", "Ivan", 880, 4, 4);
            Boss Nat = new Boss("Peterson", "Nat", 4000, "Mercedes S class");

            Jake.Work();
            Ivan.Work();
            Nat.Lead();
        }
    }
}
