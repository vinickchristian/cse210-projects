using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> ();
        int userNum = -1;
        while (userNum != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userRespn = Console.ReadLine();
            userNum = int.Parse(userRespn);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of all numbers is: {sum}");

        float average = ((float)sum)/(float)numbers.Count;
        Console.WriteLine($"The average of all numbers is: {average}");

        int maxNum = numbers[0];
        foreach (int num in numbers)
        {
            if (num > maxNum)
            {
                maxNum = num;
            }
        }
        Console.WriteLine($"The maximum number is: {maxNum}");
    }
}