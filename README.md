In C#, methods are fundamental building blocks used to encapsulate a set of code statements that perform a specific task or operation. They are defined within classes and can be called to execute their functionality. Here's an overview of how methods are structured in C#:

### Method Declaration:
```csharp
access_modifier return_type MethodName(parameters)
{
    // Method body
}
```

- **access_modifier:** Specifies the accessibility of the method (e.g., `public`, `private`, `protected`, `internal`).
- **return_type:** Specifies the data type of the value returned by the method. If the method doesn't return a value, use `void`.
- **MethodName:** The name of the method, which is used to call it.
- **parameters:** Optional input values passed to the method for processing.

### Example:
```csharp
public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public void DisplayResult(int result)
    {
        Console.WriteLine("Result: " + result);
    }
}
```

### Calling Methods:
```csharp
Calculator calc = new Calculator();
int sum = calc.Add(5, 3); // Calling the Add method
calc.DisplayResult(sum);   // Calling the DisplayResult method
```

### Method Overloading:
C# supports method overloading, which allows multiple methods with the same name but different parameters within the same class. Overloaded methods must have unique parameter lists.

```csharp
public class OverloadExample
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}
```

### Static Methods:
Static methods belong to the class itself rather than to instances of the class. They can be called using the class name.

```csharp
public class MathUtility
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}
```

### Calling Static Methods:
```csharp
int sum = MathUtility.Add(5, 3); // Calling the static Add method
```

### Summary:
- Methods in C# encapsulate code to perform specific tasks.
- They are declared within classes and can have access modifiers, return types, names, and parameters.
- Methods can return values or be void if they don't return anything.
- Method overloading allows multiple methods with the same name but different parameter lists.
- Static methods belong to the class itself and can be called using the class name.
