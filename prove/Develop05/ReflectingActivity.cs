

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity helps you reflect on moments in your life when you were strong or successful.")
     {
      _prompts = new List<string>
      {
         "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
      };
       _questions = new List<string>
        {
         "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
        };

     }
     public void Run()
     {
      DisplayStartingMessage();
        string question = GetRandomQuestion();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
     }

     private string GetRandomPrompt()
     {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
     }
     private string GetRandomQuestion()
     {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
     }
     public void DisplayPrompt()
     {
       Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine("Consider the following prompt");
        Console.WriteLine($"\n---- { _prompts[index] }----");
        Console.WriteLine();
        Console.WriteLine("When you have something in mine press enter to continue...");
        Console.ReadLine();
     }
     public void DisplayQuestions()
     {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
    HashSet<string> usedQuestions = new HashSet<string>();

    while (DateTime.Now < endTime && usedQuestions.Count < _questions.Count)
    {
        string question = GetRandomQuestion();

        // exceeds core requirements by Checking if the question has already been displayed
        if (!usedQuestions.Contains(question))
        {
            Console.WriteLine(question);
            ShowSpinner(8); // Pauses for 8 seconds before displaying the next question

            // Add the question to the set of used questions
            usedQuestions.Add(question);
        }
    }

    if (usedQuestions.Count == _questions.Count)
    {
        Console.WriteLine("All questions have been displayed.");
    }
        
     }

}