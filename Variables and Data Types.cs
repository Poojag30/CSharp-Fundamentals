/******************************************************************************
Here's a simple example that demonstrates declaring variables of different types and assigning values to them in C#
*******************************************************************************/

using System;
class program {
  static void Main() {
      
      int int_num =15;                    //integer variable
      double flot_num = 15.5;            // Floating-point variable
      char   char_name = 'P';           // Character variable
      string string_name = "Hello" ;    // String variable
      bool isTrue = true;             // Boolean variable

            // Output variables
        Console.WriteLine("Integer variable: " + int_num);
        Console.WriteLine("Floating variable: " + flot_num);
        Console.WriteLine("Character variable: " + char_name);
        Console.WriteLine("String variable: " + string_name);
        Console.WriteLine("Boolean variable: " + isTrue);
    }
}