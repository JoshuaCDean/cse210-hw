using System;
// My exceeding requirements is an option to add a character limit to the entries you write, so you have to write a certain amount.
// Had a lot of help understanding how to do some of the things I wanted to do with www.google.com, https://www.c-sharpcorner.com/article/c-sharp-list/, and https://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool menu = true;
        int character_limit = 0;
        do
        {
            Console.WriteLine("Please enter a number to select one of the following choices.\n1. Write\n2. Display\n3. Add/Change Character Limit\n4. Load\n5. Save\n6. Quit\nWhat would you like to do?: ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                PromptGenerator prompts = new PromptGenerator();
                string prompt = prompts.GivePrompt();
                Console.WriteLine(prompt);
                string entry = Console.ReadLine();
                Entry enter = new Entry();
                while (entry.Length < character_limit)
                {
                    int missing_chars = character_limit - entry.Length;
                    Console.WriteLine($"You have character limit of {character_limit}. Please write {missing_chars} more characters to continue. ");
                    string addition = Console.ReadLine();
                    entry = entry + " " + addition; 
                }
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                enter._journal = journal;
                enter._date = date;
                enter._prompt = prompt;
                enter._entry = entry;
                enter.AddEntry();
            } else if (userInput == "2")
            {
                journal.Display();

            } else if (userInput == "3")
            {
                //My exceeding Requirements had to add a TryParse check because i do not want an accidental slip up from the user to break the program! Thank you google for teaching me that!
                bool checkIsParsable = true;
                do
                {
                    Console.WriteLine("Whats the minimum amount of characters you would like to write?: ");
                    string desiredCharLimit = Console.ReadLine();
                    if(!int.TryParse(desiredCharLimit, out character_limit))
                    {
                        Console.WriteLine("Apologies that is not a correct number, please try again");
                        checkIsParsable = false;
                    } else {
                        checkIsParsable = true;
                        character_limit = int.Parse(desiredCharLimit);
                    }
                } while (!checkIsParsable);
                Console.WriteLine($"Character limit accepted! New character limit of {character_limit}");
            } else if (userInput == "4")
            {
                SaveLoad loading = new SaveLoad();
                loading._journal = journal;
                Console.WriteLine("What is the name of the file you would like to load?: ");
                string loadFile = Console.ReadLine();
                loading._loadFile = loadFile;
                loading.Load();

            } else if (userInput == "5")
            {
                SaveLoad saving = new SaveLoad();
                saving._journal = journal;
                Console.WriteLine("What do you want the name of the file to be? (EX: lovely_journal.txt): ");
                string saveFile = Console.ReadLine();
                saving._saveFile = saveFile;
                saving.Save();

            } else if (userInput == "6")
            {
                menu = false;

            } else
            {
                Console.WriteLine("Sorry you chose an invalid option please try again.");
            }

        } while (menu);
    }
}