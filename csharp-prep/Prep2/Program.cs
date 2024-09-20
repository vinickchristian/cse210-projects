using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade:");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        
        string laterGrade = "";
        if (grade >= 90)
        {
             laterGrade = "A";
        }
        else if (grade >= 80)
        {
             laterGrade = "B";
        }
        else if (grade >= 70)
        {
             laterGrade = "C";
        }
        else if (grade >= 60)
        {
             laterGrade = "D";
        }
        else 
        {
              laterGrade = "F";
        }
        
        Console.WriteLine($"Your letter grade is {laterGrade}.");

        if (grade >=70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else 
        {
            Console.WriteLine("Sorry, you failed the course.");
        }
    }
}