public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the scripture text into individual words and create Word objects
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenWords = 0;

        // Continue to hide words until the desired number is hidden
        while (hiddenWords < numberToHide)
        {
            int randomIndex = random.Next(_words.Count);
            Word wordToHide = _words[randomIndex];

            if (!wordToHide.IsHidden())
            {
                wordToHide.Hide();
                hiddenWords++;
            }
            // Break out of the loop if all words are hidden
        if (IsCompletelyHidden())
        {
            break;
        }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " - ";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
