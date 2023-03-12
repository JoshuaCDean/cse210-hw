class SimpleGoal: Goal
{
    private bool _completed = false;

    public SimpleGoal(double points, string name, string description) : base(points, name, description){}

    override public double CompleteGoal()
    {
        if (!_completed)
        {
            _completed = true;
            Console.WriteLine($"Congratulations the {GetName} goal has been completed! You have earned {GetPoints} points!");
            return GetPoints();
        } else
        {
            Console.WriteLine("This goal is already completed!");
            return 0;
        }
    }

    override public void DisplayGoal(int pos)
    {
        string completed = "[ ]";
        if (_completed)
        {
            completed = "[X]";
        }
        Console.WriteLine($"{pos}. {completed} {GetName} ({GetDescription})");
    }
}