using System;
class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Human(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}
class Teacher : Human
{
    public string TeacherId{get;set;}
    public double Salary{get;set;}
    public string Department{get;set;}

    public Teacher(string name,int age,string gender,string teacherId,double salary,string department)
        : base(name,age,gender)
    {
        TeacherId=teacherId;
        Salary=salary;
        Department=department;
    }
}
class Student:Human
{
    public string StudentId{get;set;}
    public double CGPA{get;set;}
    public string Department{get;set;}

    public Student(string name, int age, string gender, string studentId, double cgpa, string department):base(name, age, gender)
    {
        StudentId=studentId;
        CGPA=cgpa;
        Department=department;
    }
}
class ExStudent:Student
{
    public ExStudent(string name,int age,string gender,string studentId,double cgpa,string department)
        : base(name,age,gender,studentId,cgpa,department)
    {
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Teacher teacher = new Teacher("PRONOY",28,"Male","02258-504",50000,"CS");
        Console.WriteLine("Teacher: "+teacher.Name + ",Department: "+teacher.Department);

        Student student=new Student("PROTTOY",22,"Male","21-45640-3",3.83,"CSE");
        Console.WriteLine("Student: "+student.Name+", CGPA: "+student.CGPA);

        ExStudent exStudent=new ExStudent("DOPHY",24,"Male","19-65455-3",3.99,"EEE");
        Console.WriteLine("Ex-Student: " + exStudent.Name +", Department: "+exStudent.Department);
    }

}
