using System;

class Program 
{
    static void Main() 
    {
        int[] nums = new int[10];
        Random rnd = new Random();

        Console.WriteLine("A string of numbers: ");

        int temp = 1;
        for (int i = 0; i < temp; ++i)
        {
            for (int j = 0; j < nums.Length; ++j)
            {
                bool flag = true;
                int num = rnd.Next(-10, 10);

                for (int l = 0; l < j; ++l)
                {
                    if (num == nums[l])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == true)
                {
                    nums[j] = num;
                }
                else
                {
                    --j;
                }    
            }
        }

        foreach (int number in nums)
        {
            Console.Write(number + " ");
        }

        int minnum = nums[0];
        int minindex = 0;

        for (int i = 1; i < nums.Length; ++i) 
        {
            if (nums[i] < minnum)
            {
                minnum = nums[i];
                minindex = i + 1;
            }
        }

        Console.WriteLine("\nMinimum element number № " + minindex);

        Console.ReadKey();
    }
}