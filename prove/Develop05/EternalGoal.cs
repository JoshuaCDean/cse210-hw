class EternalGoal : Goal
{

    public EternalGoal(double points, string name, string description) : base(points, name, description){}


    public override double CompleteGoal()
    {
        Console.WriteLine($"Congratulations the {GetName} goal has been completed! You have earned {GetPoints} points!");
        return GetPoints();
    }

    override public void DisplayGoal(int pos)
    {
        Console.WriteLine($"{pos}. [ ] {GetName()} ({GetDescription()})");
    }

    public override string GoalConvert()
    {
        string entry = $"EternalGoal|||{GetName()}|||{GetDescription()}|||{GetPoints()}";
        return entry;
    }
}