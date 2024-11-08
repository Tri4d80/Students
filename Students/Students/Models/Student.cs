namespace Students.Models;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
        Name = "";
        Age = 0;
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} ({Age} éves)";
    }

    public static bool EqualTo(Student student1, Student student2)
    {
        return student1.Name == student2.Name && student1.Age == student2.Age;
    }
}