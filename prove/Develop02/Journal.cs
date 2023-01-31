public class Journal
{
    public string _prompt;
    public string _entry;
    public string _date;

    public List<string> _entries = new List<string>();
        
    public void Display()
    {
        foreach (string line in _entries) {
            string[] parts = line.Split("|||");
            string prompt = parts[0];
            string entry = parts[1];
            string date = parts[2];
            Console.WriteLine($"Date: {date} - Prompt: {prompt} - Entry: {entry}\n");
        };
    }
}