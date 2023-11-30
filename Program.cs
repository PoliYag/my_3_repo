using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize an array of real numbers
        double[] numbers = { 2.34, 3.56, 1.87, 4.23, 5.12 };

        // Find the minimum and maximum numbers in the array
        double minNumber = double.MaxValue;
        double maxNumber = double.MinValue;
        Console.Write("Массив ["); 
        foreach (double number in numbers)
        { Console.Write(number + " ");
            // Update the minimum and maximum numbers if necessary
            if (number < minNumber)
            {
                minNumber = number;
            }
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        // Calculate the difference between the maximum and minimum numbers
        double difference = maxNumber - minNumber;

        // Print the result
        Console.Write("] => " + difference); 
    }
}