using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 100);
       int magicNumber = number;
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNumber) {

        if (guess > magicNumber)
        {
            Console.WriteLine("higher");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("lower");
        }
        
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("You guessed it!");

    }
}