using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static int[] RandomNumberGenerator(int start, int end, int lenght)
    {
        List<int> numbers = new List<int>();
        Random rand = new Random();

        while (numbers.Count < lenght)
        {
            int randomNumber;
            do
            {
                randomNumber = rand.Next(start, end +1); 
            }
            while (numbers.Contains(randomNumber)); 
            numbers.Add(randomNumber); 
        }
        int[] result = numbers.ToArray();
        return result;
    }
    public static void Main (string[] args) 
    {
        int start = 0, end = 0, lenght = 0;
        Console.WriteLine("Enter the start of the range: ");
        start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter end of range: ");
        end = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of numbers in the range: ");
        lenght = Convert.ToInt32(Console.ReadLine());

        int []randomNumbers = RandomNumberGenerator(start, end, lenght);

        Console.WriteLine("Generated numbers:");
        foreach (int num in randomNumbers)
        {
            Console.Write(num + " "); 
        }
    }
}
