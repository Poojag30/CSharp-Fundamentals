/******************************************************************************
Here's an example of how you can create a class with constructors, properties, and methods
*******************************************************************************/

using System;

// Define a class named Person
public class Person
{
    // Constructor that takes parameters
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Method
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }

    // Static method
    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method.");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person("John", 30);

        // Access properties
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        // Call the method
        person.SayHello();

        // Call the static method
        Person.StaticMethod();
    }
}
