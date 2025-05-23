using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Teacher teacher = new Teacher("John Doe", 35, "Male", "T123", 50000, "Math");
            Console.WriteLine("Teacher: " + teacher.Name + ", Department: " + teacher.Department);

            Student student = new Student("Alice Smith", 20, "Female", "S123", 3.8, "Physics");
            Console.WriteLine("Student: " + student.Name + ", CGPA: " + student.CGPA);

            ExStudent exStudent = new ExStudent("Bob Johnson", 25, "Male", "E123", 3.5, "Chemistry");
            Console.WriteLine("Ex-Student: " + exStudent.Name + ", Department: " + exStudent.Department);
        }
    }
}
