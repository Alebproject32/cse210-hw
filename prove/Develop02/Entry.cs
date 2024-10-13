public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }
    public string Date { get; set; }

    public void Display()
    {
        this._date = "";
        this._promptText = "";
        this._entryText = "";
        Console.WriteLine(_date + _promptText + _entryText);

    }

    public Entry(string randomPrompt)
    {
        randomPrompt = "";
    }

    public Entry(string filename, string _date, string randomPrompt)
    {
        StreamReader sr = new StreamReader(filename);
        filename = sr.ReadLine();
    }

    public Entry(DateTime _date, string randomPrompt)
    {
        //Date = _date;
        _promptText = randomPrompt;

    }

}