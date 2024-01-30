using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating an instance of Calculator class
        Calculator calc = new Calculator();

        // Calling the Add method with two integers
        int sum1 = calc.Add(5, 3);
        Console.WriteLine("Sum (integers): " + sum1);

        // Calling the Add method with two doubles
        double sum2 = calc.Add(2.5, 3.7);
        Console.WriteLine("Sum (doubles): " + sum2);

        // Calling the DisplayResult method
        calc.DisplayResult(sum1);
    }
}

public class Calculator
{
    // Method to add two integers
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Method to add two doubles
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    // Method to display result
    public void DisplayResult(int result)
    {
        Console.WriteLine("Result: " + result);
    }
}
