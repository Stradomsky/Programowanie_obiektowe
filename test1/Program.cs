using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Student[] students = new Student[]
        {
            new Student("Ewa", 21),
            new Student("Jan", 25),
            new Student("Tomasz", 18),
            new Student("Mateusz", 55),
            new Student("Basia", 11),
            new Student("Kasia", 99)
        };

        Console.WriteLine("Nie posortowane: ");
        for (int i = 0; i < students.Length; ++i)
            Console.WriteLine(students[i]);

        Array.Sort(students); // podczas sortowania wykorzystana zostanie metoda CompareTo()

        Console.WriteLine("Posortowane po wieku: ");
        for (int i = 0; i < students.Length; ++i)
            Console.WriteLine(students[i]);
    }
}

public class Student : IComparable<Student>
{
    private string name;
    private int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public int CompareTo(Student other)
    {
        if (other == null) return -1;
        if (other == this) return 0;

        int diff = this.age - other.age;

        if (diff > 0) return +1;
        if (diff < 0) return -1;

        return 0; // gdy: diff == 0
    }

    public override string ToString()
    {
        return "Student: " + this.name + " " + this.age;
    }
}