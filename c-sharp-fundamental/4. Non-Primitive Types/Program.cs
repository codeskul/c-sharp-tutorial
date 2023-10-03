
// 4. Non-Primitive Types

using _4._Non_Primitive_Types.Math;

internal class Program
{
    private static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.FirstName = "Sanjay";
        p1.LastName = "Patel";
        p1.Introduce();

        Calculator calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Console.WriteLine(result);

        var result1 = Calculator.AddStatic(2, 3);
        Console.WriteLine(result1);
    }
}