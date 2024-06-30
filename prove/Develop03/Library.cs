public class Library
{
    private List<Scripture> _scriptures;
    private Random _random;

    public Library()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            Console.WriteLine("The library is empty.");
        }
        
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}