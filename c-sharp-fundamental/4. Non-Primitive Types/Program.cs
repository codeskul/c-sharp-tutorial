
// 4. Non-Primitive Types

using _4._Non_Primitive_Types.Math;

// Enums
public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2, 
    Express= 3
}

internal class Program
{
    private static void Main(string[] args)
    {
        // ##### Class #####
        Console.WriteLine("Class\n");

        Person p1 = new Person();
        p1.FirstName = "Sanjay";
        p1.LastName = "Patel";
        p1.Introduce();     // My name is Sanjay Patel

        Calculator calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Console.WriteLine(result);      // 3

        var result1 = Calculator.AddStatic(2, 3);
        Console.WriteLine(result1);     // 5

        // ##### Array #####
        Console.WriteLine("\nArray\n");

        int[] numbers = new int[3];
        numbers[0] = 1;

        Console.WriteLine(numbers[0]);      // 1     
        Console.WriteLine(numbers[1]);      // 0
        Console.WriteLine(numbers[2]);      // 0

        //bool flags = new bool[3];
        var flags = new bool[3];
        flags[0] = true;

        Console.WriteLine(flags[0]);        // True
        Console.WriteLine(flags[1]);        // False
        Console.WriteLine(flags[2]);        // False

        string[] names = new string[3] { "Sanjay", "Vivek", "Jaydeep" };

        Console.WriteLine(names[0]);        // Sanjay
        Console.WriteLine(names[1]);        // Vivek
        Console.WriteLine(names[2]);        // Jaydeep

        // ##### Strings #####
        Console.WriteLine("\nStrings\n");
        string firstName = "Sanjay";
        string lastName = "Patel";

        var fullName = firstName + " " + lastName;
        var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
        var anotherFullName = $"Another name is {firstName} {lastName}";
        var formattedNames  = string.Join(", ", names);

        Console.WriteLine(fullName);        // Sanjay Patel
        Console.WriteLine(myFullName);      // My name is Sanjay Patel
        Console.WriteLine(anotherFullName);     // Another name is Sanjay Patel
        Console.WriteLine(formattedNames);      // Sanjay, Vivek, Jaydeep

        string text = "Hi, there\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
        string verbText = @"Hi, there
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
        Console.WriteLine(text);
        Console.WriteLine(verbText);

        // ##### Enums #####
        Console.WriteLine("\nEnums\n");
        var method = ShippingMethod.Express;
        Console.WriteLine((int)method);     // 3
        Console.WriteLine(method);     // Express
        Console.WriteLine(method.ToString());       // Express
        int methodId = 3;       
        Console.WriteLine((ShippingMethod)methodId);        // Express
        string methodName = "Express";
        var shipingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        Console.WriteLine(shipingMethod);
    }
}