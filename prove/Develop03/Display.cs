class Display 
{

    private string _scripture;
    private string _reference;
    private string _display_message;

    public void GetScriptureReference(string scripture, string reference)
    { 
        _scripture = scripture;
        _reference = reference;
    }


    public void DisplayScripture()
    {
        _display_message = $"{_reference} - {_scripture}";
        Console.WriteLine(_display_message);
    }

    public bool DisplayFinale()
    {
        bool notFinished = true;
        do
        {
            Console.WriteLine("The entire scripture is hidden. Would you like to try to recite it? 'YES'?: ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Console.Clear();
                Console.WriteLine($"Please guess what {_reference} says:");
                string input = Console.ReadLine().ToLower();
                if (input == _scripture.ToLower())
                {
                    Console.WriteLine($"Congrats! You've Learned {_reference}!");
                    notFinished = false;
                } else {
                    Console.WriteLine("Sorry that's incorrect, try again!");
                };
            }
            else
            {
                notFinished= false;
            }
        } while(notFinished);
        return true;
    }
}