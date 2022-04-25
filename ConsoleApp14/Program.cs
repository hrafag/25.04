using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student("Faik", "Aliyev");
            Console.WriteLine(student.GetStudents());
        }

        class Student
        {
            public string Name;
            public string Surname;

            public Student(string name, string surname)
            {
                Name = name;
                Surname = surname;
            }

            public string GetStudents()
            {
            return $"Name:{Name}, Surname: {Surname}";
            }
        }
    }
}
