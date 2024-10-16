using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "this activity"){}

    public void run()
    {

    }
    public void GetRandomPrompts()
    {

    }
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}