using System.IO; 

public class SaveLoad
{
    public string _saveFile;
    public Journal _journal;
    public string _loadFile;


    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_loadFile);
        foreach (string line in lines)
        {
            Entry enter = new Entry();
            string[] parts = line.Split("|||");
            enter._prompt = parts[0];
            enter._entry = parts[1];
            enter._date = parts[2];
            _journal._entries.Add(enter);
        }
    }

    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_saveFile))
        {
            foreach (Entry line in _journal._entries)
            {
                line.SaveToFile(_saveFile, outputFile);
            }
        }
    }
}