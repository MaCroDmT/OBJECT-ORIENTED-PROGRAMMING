using System;
namespace ConsoleApp1
{

    class Teacher : Human
    {
        public string TeacherId { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Teacher(string name, int age, string gender, string teacherId, double salary, string department)
            : base(name, age, gender)
        {
            TeacherId = teacherId;
            Salary = salary;
            Department = department;
        }
    }
}
