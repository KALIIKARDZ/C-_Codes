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
