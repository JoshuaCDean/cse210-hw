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
            _journal._entries.Add(line);
        }
    }

    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_saveFile))
        {
            foreach (string line in _journal._entries)
            {
                outputFile.WriteLine(line);
            }
        }
    }
}