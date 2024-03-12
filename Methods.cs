/********************************************************************************************
Here's an example that demonstrates how to declare methods, pass parameters, define return types, and overload methods in C#:
*********************************************************************************************/

using System;

class Program
{
    static void Main()
    {
        // Calling a method with parameters and return value
        int sum = Add(5, 3);
        Console.WriteLine("Sum: " + sum);

        // Calling a method with no parameters and void return type
        PrintMessage();

        // Calling a method with parameters and void return type
        Greet("John");
        
         // Calling the overloaded method
        Greet("Jane", "Doe");
    }

    // Method with parameters and return type
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method with no parameters and void return type
    static void PrintMessage()
    {
        Console.WriteLine("Hello, world!");
    }

    // Method with parameters and void return type
    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    // Overloaded method
    static void Greet(string firstName, string lastName)
    {
        Console.WriteLine("Hello, " + firstName + " " + lastName + "!");
    }
}
