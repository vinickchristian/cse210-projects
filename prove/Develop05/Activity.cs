using System;
using System.Threading;
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {

        Console.WriteLine($"\nWelcom to the {_name}...");
        Console.WriteLine(_description);
        Console.Write("\nHow many seconds would you like to do this activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("Prepare to begin...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {  
        Console.Write("\nGood job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds for the {_name}.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

}