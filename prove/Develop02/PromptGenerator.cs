public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "In which way did i put into practice what i learned this morning",
            "Who did i serve today?",
        };

    }
    public string GetRandomPrompt()
    {
       Random random = new Random();
       int index = random.Next(_prompts.Count);
       return _prompts[index]; 
    }
}