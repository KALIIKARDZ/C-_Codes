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
// Math class
using System;
class Sphere
{
    static void Main()
    {
        int radius;
        double volume, surfaceArea;
        Console.WriteLine("Enter the radius of a sphere");
        radius = int.Parse(Console.ReadLine());
        volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Volume: {0} \t Suface area: {1}",
        volume, surfaceArea);
    }
}

// Multiple methods
using System; // Importing the System namespace which contains fundamental classes and base classes.

class Overloading // Defining a class named Overloading.
{
    static void Main() // Main method - the entry point of the program.
    {
        // Prompting the user to enter the number of dimensions for the shape.
        Console.Write("Enter the number of dimensions (1 for Circle, 2 for Rectangle, 2 for Triangle): ");
        int dimensions = Convert.ToInt32(Console.ReadLine()); // Reading user input and converting it to an integer.

        // Checking if the user selected 1 dimension (Circle).
        if (dimensions == 1)
        {
            // Prompting the user to enter the radius of the circle.
            Console.Write("Enter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine()); // Reading user input and converting it to a double.
            // Calculating and displaying the area of the circle using the area method.
            Console.WriteLine("Area of Circle: " + area(radius));
        }
        // Checking if the user selected 2 dimensions (Rectangle or Triangle).
        else if (dimensions == 2)
        {
            // Prompting the user to specify the shape type (rectangle or triangle).
            Console.Write("Is it a rectangle or triangle? (r/t): ");
            char shapeType = Convert.ToChar(Console.ReadLine().ToLower()); // Reading user input and converting it to lowercase.

            // Prompting the user to enter the first dimension (length or base).
            Console.Write("Enter first dimension: ");
            double firstDim = Convert.ToDouble(Console.ReadLine()); // Reading user input and converting it to a double.
            // Prompting the user to enter the second dimension (width or height).
            Console.Write("Enter second dimension: ");
            double secondDim = Convert.ToDouble(Console.ReadLine()); // Reading user input and converting it to a double.

            // Checking if the shape type is rectangle.
            if (shapeType == 'r')
            {
                // Calculating and displaying the area of the rectangle using the area method.
                Console.WriteLine("Area of Rectangle: " + area((int)firstDim, (int)secondDim));
            }
            // Checking if the shape type is triangle.
            else if (shapeType == 't')
            {
                // Calculating and displaying the area of the triangle using the area method.
                Console.WriteLine("Area of Triangle: " + area(firstDim, secondDim, true));
            }
            else
            {
                // Displaying an error message for invalid shape type.
                Console.WriteLine("Invalid shape type.");
            }
        }
        else
        {
            // Displaying an error message for invalid number of dimensions.
            Console.WriteLine("Invalid number of dimensions.");
        }
    }

    // Method to calculate the area of a circle given its radius.
    static double area(double radius)
    {
        return Math.PI * radius * radius; // Using the formula πr² to calculate the area.
    }

    // Method to calculate the area of a rectangle given its length and width.
    static int area(int length, int width)
    {
        return length * width; // Using the formula length * width to calculate the area.
    }

    // Method to calculate the area of a triangle given its base length and height.
    static double area(double baseLength, double height, bool isTriangle)
    {
        return 0.5 * baseLength * height; // Using the formula 0.5 * base * height to calculate the area.
    }
}
