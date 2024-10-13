public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        List<Entry> _entries = new List<Entry>();
        foreach (Entry newEntry in _entries)
        {
            newEntry.Display();
        }

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (Entry newEntry in _entries)
            {
                sw.WriteLine(newEntry._date);
                sw.WriteLine(newEntry._promptText);
                sw.WriteLine(newEntry._entryText);
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((filename = sr.ReadLine()) != null)
                {
                    Entry newEntry = new Entry(filename, sr.ReadLine(), sr.ReadLine());
                    _entries.Add(newEntry);
                }
            }
        }
    }
    public void WriteNewEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        string randomPrompt = promptGenerator.GetRandomPrompt();

        DateTime _date = DateTime.Now;

        Entry newEntry = new Entry(_date, randomPrompt);

        newEntry.Display();

        string userResponse = Console.ReadLine();

        newEntry._entryText = userResponse;

        _entries.Add(newEntry);

    }

}