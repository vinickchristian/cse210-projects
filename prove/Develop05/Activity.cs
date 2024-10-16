using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity...");
    }
    public void DisplayEndingMessage()
    {  
        Console.WriteLine($"Ending {_name} activity.");
    }
    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Activity is in progress...");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void ShowCountdown(int seconds)
    {
        Console.WriteLine($"Activity will end in {seconds} seconds...");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

}