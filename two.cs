using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int temp = 1;
        Console.WriteLine("enter a list of numbers, if you want to complete, then enter 0: ");
        while (temp != 0)
        {
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp != 0)
            {
                numbers.Add(temp);
            }

        }

        int sum = 0, multiplication = 1;

        foreach (int num in numbers)
        {
            sum += num;
            multiplication *= num;
        }

        float average = numbers.Count > 0 ? (float)sum / numbers.Count : 0;
        Console.WriteLine("calculated sum of numbers: " + sum);
        Console.WriteLine("calculated multiplication of numbers: " + multiplication);
        Console.WriteLine("calculated average of numbers: " + average);

        Console.ReadKey();
    }

}