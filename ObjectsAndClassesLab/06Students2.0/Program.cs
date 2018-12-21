using System;
using System.Collections.Generic;
using System.Linq;

namespace _05Students2._0
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var allStudents = new List<Student>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split();

                var firstName = tokens[0];
                var lastName = tokens[1];
                var age = int.Parse(tokens[2]);
                var city = tokens[3];

                Student student = allStudents.FirstOrDefault(s => s.FirstName == firstName
                && s.LastName == lastName);

                if (student == null)
                {
                    allStudents.Add(
                        new Student()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Age = age,
                            City = city
                        });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                line = Console.ReadLine();

            }

            var filterCity = Console.ReadLine();

            var filteredStudents = allStudents
                .Where(s => s.City == filterCity)
                .ToList();


            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

        
    }
}
