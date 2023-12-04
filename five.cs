using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the line:");
        string say = Console.ReadLine();
        string say1 = Regex.Replace(say, @"\s+", " ");

        char[] charsToTrim = { '*', ' ', '\''};

        string str = say1.Trim(charsToTrim);


        string[] words = str.Split(' ');

        int wordCount = words.Length;

        string start = "Start ", end = " End";
        string result = start + str + end;

        Console.WriteLine("number of words: " + wordCount);
        Console.WriteLine("result: " + result);

    }
}