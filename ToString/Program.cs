using System;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }

    public Person(string name, string surname, int age, double weight, double height)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Weight = weight;
        Height = height;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Surname: {Surname}, Age: {Age}, Weight: {Weight}, Height: {Height}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Get user input
        Console.WriteLine("Enter the person's name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the person's surname: ");
        string surname = Console.ReadLine();
        Console.WriteLine("Enter the person's age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the person's weight: ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the person's height: ");
        double height = double.Parse(Console.ReadLine());

        // Create a Person object
        Person person = new Person(name, surname, age, weight, height);

        // Print the person's properties to the console
        Console.WriteLine(person);
    }
}
