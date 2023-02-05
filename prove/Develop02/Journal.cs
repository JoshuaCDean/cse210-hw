public class Journal
{
    public string _prompt;
    public string _entry;
    public string _date;

    public List<Entry> _entries = new List<Entry>();
        
    public void Display()
    {
        foreach (Entry line in _entries) {
            line.DisplayEntry();
        };
    }
}