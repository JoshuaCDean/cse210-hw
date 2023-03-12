class NumberGame
{
    public NumberGame()
    {
        Random randomGenerator = new Random();
        int guesses = 0;
        int number = randomGenerator.Next(1, 500);
        bool completed = false;
        do
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);
            if (guess == number)
            {
                Console.Write($"Correct! Congratulations you win! You made {guesses} guesses.\n");
                completed = true;
            }
            else if (guess < number)
            {
                Console.Write("Higher.\n");
            }
            else if (guess > number)
            {
                Console.Write("Lower.\n");
            }
            guesses += 1;
        } while (completed != true);
        Console.ReadLine();
    }
}