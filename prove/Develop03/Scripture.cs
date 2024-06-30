public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (var word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        int unhiddenCount = _words.Count(word => !word.IsHidden());
        if (numberToHide > unhiddenCount)
        {
            numberToHide = unhiddenCount;
        }

        while (hiddenCount != numberToHide)
        {
            int index = random.Next(_words.Count);
            if(!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText()  + "\n";
        foreach (var word in _words)
        {
            text = text + word.GetDisplayText() + " ";
        }
        return text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}