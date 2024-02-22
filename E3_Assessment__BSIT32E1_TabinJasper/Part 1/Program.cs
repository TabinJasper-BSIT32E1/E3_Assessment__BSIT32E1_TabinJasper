/* Sample Assessment for Introduction to Programming */

using System;

class Program
{
    static void Main(string[] args)
    {
        //Calculate the area of a triangle
        Console.WriteLine("1.) Calculate the area of a triangle");
        double baseLength = ReadValidDouble("Enter the base of the triangle: ");
        double height = ReadValidDouble("Enter the height of the triangle: ");
        double area = 0.5 * baseLength * height;
        Console.WriteLine($"The area of the triangle is: {area}");

        //Declare an array of 5 integers and find the largest element
        Console.WriteLine("\n2.) Declare an array of 5 integers and find the largest element");
        int[] array = new int[5];
        string formula = ReadFormula("Enter the formula (e.g., n^2): ");
        for (int i = 0; i < array.Length; i++)
            array[i] = CalculateFormula(formula, i + 1);
        int maxElement = FindMaxElement(array);
        Console.WriteLine($"The largest element in the array is: {maxElement}");

        //Print each number along with its square root
        Console.WriteLine("\n3.) Print each number along with its square root");
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"Number: {i}, Square Root: {Math.Sqrt(i)}");
    }

    static double ReadValidDouble(string prompt)
    {
        double value;
        do
        {
            Console.Write(prompt);
        } while (!double.TryParse(Console.ReadLine(), out value) || value <= 0);
        return value;
    }

    static string ReadFormula(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static int CalculateFormula(string formula, int n)
    {
        return formula switch
        {
            "n^2" => n * n,
            _ => throw new ArgumentException("Invalid formula"),
        };
    }

    static int FindMaxElement(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];
        return max;
    }
}
