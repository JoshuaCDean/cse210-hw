using System.IO;
class TimeTracker
{
    private int _breathingTime = 0;
    private int _reflectingTime = 0;
    private int _listingTime = 0;


    public void AddTime(string name, int time)
    {
        using (StreamWriter outputFile = new StreamWriter($"{name}.txt") )
        {
            outputFile.WriteLine(time);
        }
    }

    public void DisplayTimes()
    {
        string[] breathingLines = System.IO.File.ReadAllLines("Breathing Activity.txt");
        foreach (string line in breathingLines)
        {
            int time = Convert.ToInt32(line);
            _breathingTime += time;
        }

        string[] reflectingLines = System.IO.File.ReadAllLines("Reflecting Activity.txt");
        foreach (string line in reflectingLines)
        {
            int time = Convert.ToInt32(line);
            _reflectingTime += time;
        }

        string[] listingLines = System.IO.File.ReadAllLines("Listing Activity.txt");
        foreach (string line in listingLines)
        {
            int time = Convert.ToInt32(line);
            _listingTime += time;
        }

        Console.Clear();
        Console.WriteLine($"You've spent {_breathingTime} seconds on the Breathing Activity.\nYou've spent {_reflectingTime} seconds on the Reflecting Activity.\nYou've spent {_listingTime} seconds on the Listing Activity.\n   Press Enter when you are finished.");
        Console.ReadLine();
        
    }

}