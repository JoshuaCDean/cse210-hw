class Activity
{
    private string _activityName;
    private int _duration;
    private string _description;
    public Activity()
    {

    }    
    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void DisplayStart()
    {
        Console.Clear();
        string startMessage = $"Welcome to the {_activityName}.\n\n{_description}\n\nHow long, in seconds, would you like for your session?";
        Console.WriteLine(startMessage);
        int userInput = int.Parse(Console.ReadLine());
        _duration = userInput;
        Console.Clear();
        Console.WriteLine("Get Ready...");
        SpinnerPause(3);
    }


    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayEnd()
    {
        Console.WriteLine("Well Done!");
        SpinnerPause(3);
        string endMessage = $"You have completed another {_duration} seconds of {_activityName}";
        Console.WriteLine(endMessage);
        SpinnerPause(3);
        TimeTracker addTime = new TimeTracker();
        addTime.AddTime(_activityName, _duration);
    }

    public void SpinnerPause(int length)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(length);

        List<string> animationStrings = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(125);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void Countdown(int length)
    {
        for (int i = length; i > 0; i--)
        {
            
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}