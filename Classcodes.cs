// Multiple parameters
using System;
class Params
{
    static void Parray(params int[] arr)
    {
        Console.Write("array elements are:");
        foreach (int i in arr)
        Console.Write(" " + i);
        Console.WriteLine();
    }
    static void Main()
    {
        int[] x = { 11, 22, 33, 44 };
        Parray(x); //call 1
        Parray(100, 200); //call 3
        Parray(30, 60, 50);
        
    }
}

// Using Out
using System;

class Output
{
    
    static void Compute(int number1, int number2, out int sum, out int difference)
    {
        sum = number1 + number2;
        difference = number1 - number2;
    }

    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());

        int sum, difference;

        Compute(number1, number2, out sum, out difference);


        
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Difference = " + difference);

    }
}
