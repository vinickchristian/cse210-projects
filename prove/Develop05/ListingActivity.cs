using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity helps you reflect on the good things in your life by listing as many items as possible.")
    {
         _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are your personal strengths?",
            "Who have you helped recently?",
            "What are the things you're grateful for?"
        };
    }

    public void Run()
    {
        
       DisplayStartingMessage();
        GetRandomPrompts();
        GetListFromUser();
        DisplayEndingMessage();
    }
    public void GetRandomPrompts()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have a few seconds to start listing your responses.");
        ShowSpinner(5);
    }
    public List<string> GetListFromUser()
    {
         List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _count = 0;

        Console.WriteLine("\nStart listing your items. Type as many as you can!");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
                _count++;
            }
        }
        return items;
    }
}