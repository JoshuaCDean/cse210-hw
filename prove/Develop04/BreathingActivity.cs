class BreathingActivity : Activity
{
    private int _duration;
    public BreathingActivity(string name, string description) : base(name, description)
    {
       DisplayStart();
       _duration = GetDuration();
       StartActivity();
    }

    private void StartActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n");
            Console.Write("Breathe In...");
            if ( (endTime-DateTime.Now).TotalSeconds < 10)
            {
                int time_remaining = Convert.ToInt32((endTime-DateTime.Now).TotalSeconds);
                Countdown(time_remaining/2);
                Console.WriteLine("\n");
                Console.Write("Breathe Out...");
                Countdown(time_remaining/2);
            } else
            {
                Countdown(4);
                Console.WriteLine("\n");
                Console.Write("Breathe Out...");
                Countdown(6);
            }
        }

        DisplayEnd();
    }
}