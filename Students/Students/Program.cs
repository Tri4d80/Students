using Students.Models;
namespace Students;

class Program
{
    static void Main()
    {
        Student adel = new Student("Kis Adél", 19);
        Student janos = new Student("Kis Janos", 19);

        Console.WriteLine(adel);
        Console.WriteLine(janos);

        if (Student.EqualTo(adel, janos))
        {
            Console.WriteLine("A két diák adatai megegyeznek!");
        }
        else
        {
            Console.WriteLine("A két diák adatai nem egyeznek meg!");
        }
        
        if (!Student.IsYounger(adel, janos) && !Student.IsYounger(janos, adel))
        {
            Console.WriteLine("A két diák ugyanannyi éves!");
        }
        else if (Student.IsYounger(adel, janos))
        {
            Console.WriteLine("Adél fiatalabb Jánosnál!");
        }
        else
        {
            Console.WriteLine("János fiatalabb Adélnál!");
        }
    }
}