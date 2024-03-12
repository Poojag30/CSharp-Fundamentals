/******************************************************************************
Here's a basic example demonstrating the use of various types of operators in C#:
*******************************************************************************/

using System;
class Program {
  static void Main() {
    Console.WriteLine("Enter Num 1 : ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Num 2 : ");
    int b = Convert.ToInt32(Console.ReadLine());
    
    // Arithmetic operators
    Console.WriteLine("Addition : " +(a+b));
    Console.WriteLine("Subtraction : " +(a-b));
    Console.WriteLine("Multiplication : " +(a*b));
    Console.WriteLine("Division : " +(a/b));
    Console.WriteLine("Moduluse : " +(a%b));
   
    // Comparison operators
    Console.WriteLine("Equal to: " + (a == b));
    Console.WriteLine("Not equal to: " + (a != b));
    Console.WriteLine("Greater than: " + (a > b));
    Console.WriteLine("Less than: " + (a < b));
    Console.WriteLine("Greater than or equal to: " + (a >= b));
    Console.WriteLine("Less than or equal to: " + (a <= b));
 
    // Logical operators
    bool x = true;
    bool y = false;
    Console.WriteLine("Logical AND: " + (x && y));
    Console.WriteLine("Logical OR: " + (x || y));
    Console.WriteLine("Logical NOT: " + (!x));

    // Assignment operators
    int c = 10;
    c += 5;  // c = c + 5
    Console.WriteLine("Assignment operator: " + c);
  }
}
