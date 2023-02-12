class Word
{
    private Random randomGenerator = new Random();
    private string _scripture = "";

    public string HideWord() 
    {
        string[] parts = _scripture.Split(" ");
        string[] partChecker = _scripture.Split(" ");
        int partAmount= 0;
        foreach (string part in partChecker)
        {
           string partCheck = part.Replace("_", "");
           if (partCheck!="")
           {
            partAmount += 1;
           };
        }
        
        int changeNum = 0;
        if (partAmount > 5)
        {
            changeNum = randomGenerator.Next(1,5);
        } else
        {
            if (1 > partAmount) {
                changeNum = 0;
            } else { changeNum = partAmount;}
        };

        do
        {
            int randomNumber = randomGenerator.Next(0, parts.Length);
            string word = parts[randomNumber];
            string wordCheck = word;
            wordCheck = wordCheck.Replace("_", "");
            if (wordCheck != "")
            {

                string replacement="";
                foreach (char c in word) 
                {
                    replacement += char.Parse("_");
                }
                Console.WriteLine($"WORD IS: {word}");
                parts[randomNumber] = replacement;
                Console.WriteLine($"NOW IT IS IS: {parts[randomNumber]}");
                
                changeNum = changeNum-1;
            };
        } while (changeNum >= 1);
        
        string updatedScrip = "";
        foreach (string words in parts)
        {
            updatedScrip += $"{words} ";
        }
        _scripture = updatedScrip;
        return _scripture;
    }

    public void SetScripture(string scripture)
    {
        _scripture = scripture;
    }
    public bool AllWordsHidden()
    {
        string tempScript = _scripture.Trim();
        bool hidden = true;
        tempScript = tempScript.Replace("_", "");
        tempScript = tempScript.Replace(" ", "");
        tempScript = tempScript.Trim();
        if (tempScript != "")
        {
            Console.WriteLine("GOT IN");
            hidden = false;
        }
        return hidden;
    }
}