public class PromptGenerator
{
    List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How did I show my love for the Lord today?",
        "Did I make any plans for future dates today?",
        "What was I most excited about today?",
        "Did I go anywhere special today?",
    
    };

    public string GivePrompt()
    {  
        Random randomgenerator = new Random();
        int randomNumber = randomgenerator.Next(0, _prompts.Count());

        return _prompts[randomNumber];
    }
}