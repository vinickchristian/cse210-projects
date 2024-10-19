using System.Collections.Generic;

public class BreathingActivity : Activity
{

 public BreathingActivity() : base("Breathing activity", "This activity will help you relax by guiding you through deep breathing. Focus on your breathing.")
    {}
    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(5);
        }

        DisplayEndingMessage();
    
    }
}