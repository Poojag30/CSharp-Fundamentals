/******************************************************************************
Here's an example that demonstrates the use of control flow statements in C#
*******************************************************************************/

using System;

class ControlFlowExample
{
    static void Main()
    {
        // If statement
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("Number is positive");
        }

        // Switch statement
        int option = 2;
        switch (option)
        {
            case 1:
                Console.WriteLine("Option 1 selected");
                break;
            case 2:
                Console.WriteLine("Option 2 selected");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

        // For loop
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("For loop iteration: " + i);
        }

        // While loop
        int j = 0;
        while (j < 3)
        {
            Console.WriteLine("While loop iteration: " + j);
            j++;
        }

        // Do-while loop
        int k = 0;
        do
        {
            Console.WriteLine("Do-while loop iteration: " + k);
            k++;
        } 
        while (k < 3);
    }
}
