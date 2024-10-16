using System.Collections.Generic;

public class BreathingActivity : Activity
{

 public BreathingActivity() : base("Breathing", "This activity")
    {}
    public void run()
    {
        Console.WriteLine("Inhaling deeply, exhaling slowly");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("Inhaling deeply, exhaling slowly");
    }
}