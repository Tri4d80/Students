using Students.Models;

namespace Students;

class Program
{
    static void Main()
    {
        Student adel = new Student("Kis Adél", 17);
        
        Console.WriteLine(adel);
    }
}