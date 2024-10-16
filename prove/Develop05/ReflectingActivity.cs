

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Listing", "this activity")
     {}
     public void run()
     {}

     public string GetRandomPrompt()
     {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
     }
     public string GetRandomQuestion()
     {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
     }
     public void DisplayPrompt()
     {}
     public void DisplayQuestion()
     {}

}