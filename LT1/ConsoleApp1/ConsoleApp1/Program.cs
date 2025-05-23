using System;
class Program
{
    static void Main()
    {
        int[] numbers = {10,15,100,99,98,97,95 };
        int largest = numbers[0];
        int smallest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
            if (number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine("Largest number: " + largest);
        Console.WriteLine("Smallest number: " + smallest);
    }
}

