using System;
using System.ComponentModel.DataAnnotations;

public class Test
{
public static void Main()
{
        Console.Write("Enter the first number: ");
        bool isValidNum1 = double.TryParse(Console.ReadLine(), out double num1);

        Console.Write("Enter the second number: ");
        bool isValidNum2 = double.TryParse(Console.ReadLine(), out double num2);
       
        if (!isValidNum1 || !isValidNum2)
        {
            Console.WriteLine("Invalid input. Please enter valid numeric values.");
        }
        else
        {
            double sum = num1 + num2;            
            double difference = num1 - num2;     
            double product = num1 * num2;     
            
            if (num2 != 0)
            {
                double quotient = num1 / num2;   
                Console.WriteLine($"\nResults:");
                Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
                Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
                Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");
                Console.WriteLine($"Division: {num1} / {num2} = {quotient}");
            }
            else
            {
                Console.WriteLine($"\nResults:");
                Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
                Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
                Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");
                Console.WriteLine("Division: Cannot divide by zero.");
            }
        }
    }

  
}

