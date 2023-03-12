class SaveLoad
{
    public void Save(string saveFile, List<Goal> goals, double points)
    {
        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
            outputFile.WriteLine(points);
            foreach (Goal goal in goals)
            {
                string entry = goal.GoalConvert();
                outputFile.WriteLine(entry);
            }
        }
    }

    public List<Goal> Load(string loadFile)
    {
        List<Goal> goals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|||");
            string goalType = parts[0];
            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = Convert.ToInt32(parts[3]);
                bool complete = Convert.ToBoolean(parts[4]);
                Goal goal = new SimpleGoal(points, name, description, complete);
                goals.Add(goal);
            } else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = Convert.ToInt32(parts[3]);
                Goal goal = new EternalGoal(points, name, description);
                goals.Add(goal);
            } else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = Convert.ToInt32(parts[3]);
                int bonusPoints = Convert.ToInt32(parts[4]);
                int completeAmount = Convert.ToInt32(parts[5]);
                int completion = Convert.ToInt32(parts[6]);
                Goal goal = new ChecklistGoal(points, name, description, bonusPoints, completeAmount, completion);
                goals.Add(goal);
            }

        }
        return goals;
    }

    public int LoadPoints(string loadFile)
    {
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        int points = Convert.ToInt32(lines[0]);
        return points;
    }
}