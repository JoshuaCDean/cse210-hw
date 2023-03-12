abstract class Goal {

    string _name;
    double _points;


    public Goal(double points, string name)
    {
        _points = points;
        _name = name;
    }

    abstract public void CompleteGoal();

    virtual public void DisplayGoal(int pos)
    {
        Console.WriteLine($"{pos}. [ ] {_name}");
    }
}