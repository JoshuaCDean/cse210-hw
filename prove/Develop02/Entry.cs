public class Entry
{
    public Journal _journal;
    public string _prompt;
    public string _entry;
    public string _date;

    public void AddEntry()
    {
        string complete_entry = _prompt + "|||" + _entry + "|||" + _date;
        _journal._entries.Add(complete_entry);
    }

}