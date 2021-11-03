    using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            Hashtable table = new Hashtable();
            students[0] = new Student(9, "Peter", 5.66);
            students[1] = new Student(33, "Jon", 4.66);
            students[2] = new Student(9, "Natalie", 2.93);
            students[3] = new Student(6, "Ivan", 5.82);
            students[4] = new Student(12, "Sarah", 3.46);

            foreach(Student student in students)
            {
                if (table.ContainsKey(student.id))
                {
                    Console.WriteLine("Student with this id already exists.");
                    continue;
                }
                    

                table.Add(student.id, student);
            }

            foreach(DictionaryEntry element in table)
            {
                Student student = (Student)element.Value;
                Console.WriteLine($"Id:{student.id}, name:{student.name} and GPA:{student.GPA}.");
            }
        }

        

        class Student
        {
            public int id;

            public string name;

            public double GPA { get; set; }

            public Student(int id, string name, double GPA)
            {
                this.id = id;
                this.name = name;
                this.GPA = GPA;
            }
        }
    }
}
