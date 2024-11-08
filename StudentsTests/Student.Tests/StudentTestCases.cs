namespace Student.Tests;
using Students.Models;

[TestClass]
public class StudentTestCases
{
    [TestMethod]
    public void Test_WhenAllDataIsEqual()
    {
        Student first  = new Student("Kis Adél", 17);
        Student second  = new Student("Kis Adél", 17);
        Assert.IsTrue(Student.EqualTo(first, second), "A két diák adatai nem egyeznek meg!");
    }
    
    [TestMethod]
    public void Test_WhenNamesAreDifferent()
    {
        Student first  = new Student("Kis Adél", 17);
        Student second  = new Student("Nagy Adél", 17);
        Assert.IsTrue(Student.NamesAreDifferent(first, second), "A két diák neve nem tér el!");
    }

    [TestMethod]
    public void Test_WhenAgesAreDifferent()
    {
        Student first  = new Student("Kis Adél", 17);
        Student second  = new Student("Kis Adél", 18);
        Assert.IsTrue(Student.AgesAreDifferent(first, second), "A két diák életkora nem tér el!");
    }

    [TestMethod]
    public void Test_WhenAllDataIsDifferent()
    {
        Student first  = new Student("Kis Adél", 17);
        Student second  = new Student("Nagy Adél", 18);
        Assert.IsTrue(Student.AllDataIsDifferent(first, second), "A diákok adatai részben vagy egészében egyeznek!");
    }

    [TestMethod]
    public void Test_WhenFirstStudentIsYounger()
    {
        Student first  = new Student("Kis Adél", 17);
        Student second  = new Student("Nagy Adél", 18);
        Assert.IsTrue(Student.IsYounger(first, second), "Az első diák nem fiatalabb!");
    }
    
    [TestMethod]
    public void Test_WhenSecondStudentIsYounger()
    {
        Student first  = new Student("Kis Adél", 17);
        Student second  = new Student("Nagy Adél", 16);
        Assert.IsTrue(Student.IsYounger(second, first), "A második diák nem fiatalabb!");
    }
    
    [TestMethod]
    public void Test_WhenEqualAges()
    {
        Student first  = new Student("Kis Adél", 17);
        Student second  = new Student("Nagy Adél", 17);
        Assert.IsTrue(!Student.IsYounger(second, first) && !Student.IsYounger(first, second), "A két diák kora nem egyezik meg!");
    }
    
    
    
}