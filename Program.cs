using System;


public class StudentClass
{
    private string name;
    private int age;
    private int id;

    public StudentClass(string name, int age, int id)
    {
        this.name = name;
        this.age = age;
        this.id = id;
    }

    public void Add()
    {
        Console.WriteLine("Enter student name:");
        name = Console.ReadLine();
    }

    public void Delete()
    {
        Console.WriteLine("Remove student detail");
        // Implement the deletion logic here
    }
}

public class UndergradClass : StudentClass
{
    public UndergradClass(string name, int age, int id) : base(name, age, id)
    {
        Console.WriteLine("Undergraduate");
    }

    static void Main(string[] args)
    {
        string name = "John"; // Provide a name
        int age = 20; // Provide an age
        int id = 12345; // Provide an id

        UndergradClass undergraduate = new UndergradClass(name, age, id);
        undergraduate.Add();
        undergraduate.Delete();
    }
}

public class PostgradClass : StudentClass
{
    public PostgradClass(string name, int age, int id) : base(name, age, id)
    {
        Console.WriteLine("Masters/PhD");
    }

    public static void Main(string[] args)
    {
        string name = "Alice"; // Provide a name
        int age = 25; // Provide an age
        int id = 67890; // Provide an id

        PostgradClass postgraduate = new PostgradClass(name, age, id);
        postgraduate.Add();
        postgraduate.Delete();
    }
}
