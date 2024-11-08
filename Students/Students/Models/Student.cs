namespace Students.Models;

public class Student(string name = "Ismeretlen", int age = 0)
{
    private string Name { get; set; } = name;
    private int Age { get; set; } = age;

    public override string ToString()
    {
        return $"{Name} ({Age} éves)";
    }

    public static bool EqualTo(Student student1, Student student2)
    {
        return student1.Name == student2.Name && student1.Age == student2.Age;
    }

    public static bool NamesAreDifferent(Student student1, Student student2)
    {
        return student1.Name != student2.Name && student1.Age == student2.Age;
    }
    
    public static bool AgesAreDifferent(Student student1, Student student2)
    {
        return student1.Name == student2.Name && student1.Age != student2.Age;
    }
    
    public static bool AllDataIsDifferent(Student student1, Student student2)
    {
        return student1.Name != student2.Name && student1.Age != student2.Age;
    }

    public static bool IsYounger(Student student1, Student student2)
    {
        return student1.Age < student2.Age;
    }
}