class SimpleGoal: Goal
{
    bool _completed = false;

    public SimpleGoal(double points, string name) : base(points, name){}



    override public void CompleteGoal()
    {
        _completed = true;
    }
}