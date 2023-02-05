public class Entry
{
    public Journal _journal;
    public string _prompt;
    public string _entry;
    public string _date;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt} - Entry: {_entry}\n");
    }

    public void SaveToFile(string saveFile, StreamWriter output)
    {
        string complete_entry = _prompt + "|||" + _entry + "|||" + _date;
        output.WriteLine(complete_entry);
    }
}