using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> elements = new List<string>();

        Console.WriteLine("Enter the list items, enter a blank line to complete:");

        string element = Console.ReadLine();

        while (element != null && element.Trim() != "")
        {
            elements.Add(element);
            element = Console.ReadLine();
        }

        if (elements.Count > 0)
        {
            string immortal = elements[0];
            string mortal = elements[0];

            foreach (string thing in elements)
            {
                if (thing.Length < mortal.Length)
                {
                    mortal = thing;
                }

                if (thing.Length > immortal.Length)
                {
                    immortal = thing;
                }
            }

            Console.WriteLine("shortest list element: " + mortal);
            Console.WriteLine("longest list element: " + immortal);
        }
        else
        {
            Console.WriteLine("empty list...");
        }
    }
}