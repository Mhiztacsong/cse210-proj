public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity (string name, string description, int duration, int count, List<string> prompts) : base (name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {
        List<string> userlist = new List<string>();
        return userlist;
    }
}