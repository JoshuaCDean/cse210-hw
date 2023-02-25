class ListingActivity : Activity
{
    List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    int _duration;
    public ListingActivity( string name, string description) : base(name, description)
    {
        DisplayStart();
        _duration = GetDuration();
        StartActivity();
    }

    private void StartActivity()
    {
        Random randomGenerator = new Random();
        string randPrompt = _prompts[randomGenerator.Next(0,_prompts.Count())];
        Console.WriteLine($"List as many responses you can to the following prompt:\n --- {randPrompt} ---");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int items = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            items++;
        }
        Console.WriteLine($"You listed {items} items!");
        DisplayEnd();
    }
}