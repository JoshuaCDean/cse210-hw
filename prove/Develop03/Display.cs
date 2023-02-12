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
}