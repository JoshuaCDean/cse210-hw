class ReflectingActivity : Activity
{
     List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    int _duration;
    public ReflectingActivity( string name, string description) : base(name, description)
    {
        DisplayStart();
        _duration = GetDuration();
        StartActivity();
    }

    private void StartActivity()
    {
        Random randomGenerator = new Random();
        string randPrompt = _prompts[randomGenerator.Next(0,_prompts.Count())];
        Console.WriteLine($"Consider the following prompt:\n--- {randPrompt} ---\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\n Now ponder on each of the following questions as they related to this experience.\n");
        Console.Write("You may begin in: ");
        Countdown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.Clear();
        while (DateTime.Now < endTime)
        {
            string randQuestion = _questions[randomGenerator.Next(0, _questions.Count())];
            Console.Write($"{randQuestion} ");
            if ( (endTime-DateTime.Now).TotalSeconds < 10)
            {
                int time_remaining = Convert.ToInt32((endTime-DateTime.Now).TotalSeconds);
                SpinnerPause(time_remaining);
                Console.WriteLine();
            } else
            {
                SpinnerPause(10);
                Console.WriteLine();
            }

        }
        DisplayEnd();
    }
}