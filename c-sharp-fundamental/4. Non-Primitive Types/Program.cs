
// 4. Non-Primitive Types

using _4._Non_Primitive_Types.Math;

internal class Program
{
    private static void Main(string[] args)
    {
        // Class
        Console.WriteLine("Class");

        Person p1 = new Person();
        p1.FirstName = "Sanjay";
        p1.LastName = "Patel";
        p1.Introduce();

        Calculator calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Console.WriteLine(result);

        var result1 = Calculator.AddStatic(2, 3);
        Console.WriteLine(result1);

        // Array
        Console.WriteLine("\nArray");

        int[] numbers = new int[3];
        numbers[0] = 1;

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);

        //bool flags = new bool[3];
        var flags = new bool[3];
        flags[0] = true;

        Console.WriteLine(flags[0]);
        Console.WriteLine(flags[1]);
        Console.WriteLine(flags[2]);

        string[] names = new string[3] { "Sanjay", "Vivek", "Jaydeep" };

        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
    }
}