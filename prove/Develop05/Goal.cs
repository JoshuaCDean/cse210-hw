abstract class Goal {

    private string _name;
    private double _points;
    private string _description;


    public Goal(double points, string name, string description)
    {
        _points = points;
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetPoints()
    {
        return _points;
    }

    public string GetDescription()
    {
        return _description;
    }


    abstract public double CompleteGoal();

    abstract public void DisplayGoal(int pos);
}