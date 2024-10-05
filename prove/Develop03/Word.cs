public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
       
    }
    
    public void Hide()
    {
        _isHidden = true;
    }
    
    public void Show()
    {
        _isHidden = false;
    
    }
    
    public bool IsHidden()
    {
        return _isHidden;
    }
    
    public string GetDisplayText()
    {
        // If the word is hidden, return underscores instead of the actual text
         if (_isHidden)
        {
            // Return underscores for hidden words (matching the length of the original word)
            return new string('_', _text.Length);
        }
        else
        {
            // Return the word itself if it's not hidden
            return _text;
        }
    }
}