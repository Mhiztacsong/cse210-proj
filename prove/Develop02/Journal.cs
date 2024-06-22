public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine();
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries to display.");
            Console.WriteLine();
        }
        else
        {
            foreach (Entry newEntry in _entries)
            {
                newEntry.Display();
            }
        } 
    }

    public void SaveToFile(List<Entry> _entries)
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry newEntry in _entries)
            {
                outputFile.WriteLine($"{newEntry._date}|{newEntry._promptText}|{newEntry._entryText}");
            }
        }
        
        Console.WriteLine($"Entries saved successfully in {fileName} file.");

        Console.WriteLine();
    }

    public void LoadFromFile()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            // Clear unsaved existing entries
            _entries.Clear(); 
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                Entry newEntry= new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                _entries.Add(newEntry);
            }
            Console.WriteLine("Entries Loading Complete");
            Console.WriteLine();
        }
 
        else
        {
            Console.WriteLine("File Not found");
            Console.WriteLine();
        }
    }  

    public void DeleteFile()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            Console.WriteLine($"{fileName} file deleted successfully");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("File Not Found");
            Console.WriteLine();
        }

    }  
}
    