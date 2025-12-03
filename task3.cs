using System;
interface IPrintableClass<T> where T : class
{
    void Print();
}
class Student : IPrintableClass<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public void Print()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}, Grade: {Grade}");
    }
}
class Vector : IPrintableClass<Vector>
{
    public double X, Y, Z;

    public Vector(double x, int y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Print()
    {
        Console.WriteLine($"Vector: ({X}, {Y}, {Z})");
    }
}

class Program
{
    static void Main()
    {
        IPrintableClass<Student> student = new Student("Иван", 20, 4.7);
        IPrintableClass<Vector> vector = new Vector(1.0, 2, 3.0);

        student.Print();
        vector.Print();

        Console.ReadLine();
    }
}
