using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripCall = new Scripture();
        string scripture = scripCall.GiveScripture();
        string reference = scripCall.GiveReference();
        Word wordCheck = new Word();
        Display displayCheck = new Display();
        bool quit = false;
        do {

            //Set Word Class Scripture
            wordCheck.SetScripture(scripture);

            //Give Display Scripture, and Reference and then Display
            displayCheck.GetScriptureReference(scripture, reference);
            displayCheck.DisplayScripture();


            //Enter Or Quit Functionality
            Console.WriteLine("Press enter to continue or type 'quit' to continue");
            string input = Console.ReadLine().ToLower();
            bool allHidden = wordCheck.AllWordsHidden();
            if (input == "quit") {
                quit = true;
            };
            // EXCEEDING REQUIREMENTS chance to guess the prompt after it is all hidden
            if (allHidden) {
                quit = displayCheck.DisplayFinale();
            }
            //Hide Words for next Cycle
            scripture = wordCheck.HideWord();
        } while (!quit);
    }
}