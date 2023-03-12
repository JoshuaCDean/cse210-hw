abstract class Goal {
    double _points;


    public Goal(double points)
    {
        _points = points;
    }

    abstract public void CreateNewGoal();

    abstract public void CompleteGoal();

    public void DisplayGoal()
    {

    }
}