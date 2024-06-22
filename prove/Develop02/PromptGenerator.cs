using System.Security.Cryptography;

public class promptGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomString = _prompts[randomIndex];
        return randomString;
    }
}