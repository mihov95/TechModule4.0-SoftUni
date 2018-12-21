using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Students
{
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        //public override string ToString()
        //{
        //    return $"{FirstName} {LastName}: {Grade}";
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < countStudents; i++)
            {
                string[] splittedInput = Console.ReadLine().Split();

                string firstName = splittedInput[0];
                string lastName = splittedInput[1];
                double grade = double.Parse(splittedInput[2]);

                var student = new Student(firstName, lastName, grade);

                students.Add(student);

            }
                var orderedStudents = students.OrderByDescending(x=>x.Grade).ToList();

            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
