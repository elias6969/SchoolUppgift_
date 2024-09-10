using System;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Main
{
  class Program
  {
    static void Main(string[] args)
    {
      
    }
  }
public class Uppgift2
{
    public void CountWords()
    {
        Console.WriteLine("Skriv en mening: ");
        string sentenceUserInput = Console.ReadLine()!;

        string[] words = sentenceUserInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        Console.WriteLine("Antal ord: " + wordCount);
    }
}

public class Uppgift3
{
    // Method to check if a string is a palindrome
    public bool IsPalindrome(string input)
    {
        // Remove spaces and make lowercase for consistency
        string cleanedInput = input.Replace(" ", "").ToLower();
        char[] reversedArray = cleanedInput.ToCharArray();
        Array.Reverse(reversedArray);
        string reversedInput = new string(reversedArray);
        return cleanedInput == reversedInput;
    }
}

public class Uppgift4
{
    public void CalculateMedianAndShuffle()
    {
        int[] numbers = new[] { 1, 2, 3, 4, 5 };

        // Shuffle the array 'numbers' using LINQ
        int[] shuffled = numbers
            .OrderBy(n => Guid.NewGuid()) // For each element 'n', generate a new random GUID as the sorting key
            .ToArray();                   // Convert the ordered sequence back into an array

        double median = CalculateMedian(shuffled);
        Console.WriteLine($"Median: {median}");
    }

    static double CalculateMedian(int[] numbers)
    {
        Array.Sort(numbers);

        int size = numbers.Length; // For checking every array in numbers
        int mid = size / 2; // For median

        // Check if the count of numbers is even or odd
        if (size % 2 == 0)
        {
            // Even count, average the two middle numbers
            return (numbers[mid - 1] + numbers[mid]) / 2.0;
        }
        else
        {
            // Odd count, return the middle number
            return numbers[mid];
        }
    }
}

public class Uppgift5
{
    public void SumDigitsInString()
    {
        string differential = "5hej1jag34heter8ironman";
        int store = 0; // To store the sum of numbers

        for (int i = 0; i < differential.Length; i++) // Loop through the length of the string
        {
            if (Char.IsDigit(differential[i])) // Check whether there is a number and if there is, add to int store
                store += int.Parse(differential[i].ToString());
        }
        Console.WriteLine("Sum of digits: " + store);
    }
}

public class Uppgift6
{
    public void CalculateFactorial()
    {
        BigInteger factorialNumber = 0;
        BigInteger fullNumber = 1; // Use BigInteger to handle large results
        
        Console.WriteLine("Hey, please put in a number and I'll calculate the factorial: ");
        factorialNumber = BigInteger.Parse(Console.ReadLine()!); // Use BigInteger.Parse for large input
        
        // Loop from the factorial number down to 1.
        for (BigInteger j = factorialNumber; j > 0; j--)
        {
            fullNumber *= j; 
        }
        
        // Print the final result stored in fullNumber.
        Console.WriteLine("Factorial Value: {0}", fullNumber);
    }
}

public class Uppgift7
{
    public void GuessingGame()
    {
        bool gameloop = true; // Set to true to keep the game running until conditions break it
        Random rand = new Random();
        int randomNumber = rand.Next(1, 11); // Random number between 1 and 10 inclusive
        int lifes = 4;
        int guessNumber = 0;
        int low = randomNumber - 2;
        int high = randomNumber + 2;

        Console.WriteLine("Hey, and welcome to the Guessing Game. The number is between 1 and 10\n");
        Console.WriteLine("Lifes: {0}\nHint = -1 life (write 'hint' to get a hint)\nTake a guess:", lifes);

        while (gameloop)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "hint") // Check if the user asked for a hint
            {
                if (lifes > 1) // Only give a hint if there's more than 1 life left
                {
                    lifes--; // Lose a life for using the hint
                    Console.WriteLine("Hint: The number is between {0} and {1}.", low, high);
                    Console.WriteLine("Lifes: {0}", lifes);
                }
                else
                {
                    Console.WriteLine("You don't have enough lifes to get a hint!");
                }
                continue; // Skip to the next loop iteration
            }
            // Try to convert input to a number
            if (int.TryParse(input, out guessNumber))
            {
                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("You guessed right!");
                    gameloop = false; // End the game
                }
                else
                {
                    lifes--;
                    Console.WriteLine("Wrong guess!");
                    Console.WriteLine("Lifes: {0}", lifes);
                }
                if (lifes == 0)
                {
                    Console.WriteLine("Game over! The correct number was {0}.", randomNumber);
                    gameloop = false; // End the game
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number or 'hint'.");
            }
            // If the game loop continues, prompt for another guess
            if (gameloop)
            {
                Console.WriteLine("Take another guess:");
            }
        }
    }
}

public class SimpleCalculator
{
    // Method for simple calculations: addition, subtraction, multiplication, division
    public double Uppgift8(double num1, double num2, string operation)
    {
        switch (operation)
        {
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "*":
                return num1 * num2;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero");
                    return double.NaN;
                }
                return num1 / num2;
            default:
                Console.WriteLine("Invalid operation");
                return double.NaN;
        }
    }
}

public class BmiCalculator
{
    // Method to calculate BMI
    public double Uppgift9(double weight, double height)
    {
        // BMI = weight (kg) / (height (m) * height (m))
        return weight / (height * height);
    }
}