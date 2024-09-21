using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = promptUserName();
        int userNumber = promptUserNumber();

        int SqaredNumber = sqaredNumber(userNumber);
        displayResults(userName, SqaredNumber);
    }
    
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static string promptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    
    static int promptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    
    static int sqaredNumber(int number)
    {
        int square = number * number;
        return square;
    }
    
    static void displayResults(string Name, int squared)
    {
        Console.WriteLine($"{Name}, the square of your number is {squared}.");
    }
    
}