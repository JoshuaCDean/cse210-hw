class ChecklistGoal : Goal
{
    int _completion;
    int _completeAmount;
    double _bonusPoints;
    public ChecklistGoal(double points, string name, string description, int checkAmount, double bonus) : base(points, name, description)
    {
        _completeAmount = checkAmount;
        _bonusPoints = bonus;
    }
    public override double CompleteGoal()
    {
        if (_completion == _completeAmount)
        {
            Console.WriteLine("This goal is already completed!");
            return 0;
        } 
        {
            _completion++;

            Console.WriteLine($"Congratulations! You have earned {GetPoints} points!");
            if (_completion == _completeAmount)
            {
                Console.WriteLine($"Congratulations the {GetName} goal has been completed! You have earned {_bonusPoints} bonus points for completing the goal!");
                return GetPoints() + _bonusPoints;
            } else
            {
                return GetPoints();
            }
            
        
        }
    }

    public override void DisplayGoal(int pos)
    {
        string completed = "[ ]";
        if (_completion == _completeAmount)
        {
            completed = "[X]";
        }
        Console.WriteLine($"{pos}. {completed} {GetName} ({GetDescription}) -- Currently completed: {_completion}/{_completeAmount}");
    }
}