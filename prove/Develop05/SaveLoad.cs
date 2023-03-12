class SaveLoad
{
    public void Save(string saveFile, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
        }
    }

    public List<Goal> Load(string loadfile)
    {
        List<Goal> goals = new List<Goal>();
        return goals;
    }
}