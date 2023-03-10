using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        List<Goal> goals = new List<Goal>();
        double points = 0;
        do
        {

            Console.WriteLine($"\nYou have {points} points.\n\nMenu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Points Shop\n  7. Quit\nSelect a choice from the menu: ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("\nThe types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create?: ");
                string goalChoice = Console.ReadLine();
                if (goalChoice == "1")
                {
                    Console.WriteLine("\nWhat is the name of your goal?: ");
                    string myGoal = Console.ReadLine();
                    Console.WriteLine("What is a short description of your goal?:");
                    string myDesc = Console.ReadLine();
                    Console.WriteLine("What is the amount of points for this goal?:");
                    double myPoints = Convert.ToInt32(Console.ReadLine());
                    SimpleGoal newGoal = new SimpleGoal(myPoints, myGoal, myDesc);
                    goals.Add(newGoal);
                } else if (goalChoice == "2")
                {
                    Console.WriteLine("What is the name of your goal?: ");
                    string myGoal = Console.ReadLine();
                    Console.WriteLine("What is a short description of your goal?:");
                    string myDesc = Console.ReadLine();
                    Console.WriteLine("What is the amount of points for this goal?:");
                    double myPoints = Convert.ToInt32(Console.ReadLine());
                    EternalGoal newGoal = new EternalGoal(myPoints, myGoal, myDesc);
                    goals.Add(newGoal);
                } else if (goalChoice == "3")
                {
                    Console.WriteLine("What is the name of your goal?: ");
                    string myGoal = Console.ReadLine();
                    Console.WriteLine("What is a short description of your goal?:");
                    string myDesc = Console.ReadLine();
                    Console.WriteLine("What is the amount of points for this goal?:");
                    double myPoints = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                    int checkAmount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times?");
                    double bonus = Convert.ToInt32(Console.ReadLine());
                    ChecklistGoal newGoal = new ChecklistGoal(myPoints, myGoal, myDesc, checkAmount, bonus);
                    goals.Add(newGoal);
                } else
                {
                    Console.WriteLine("\nSorry you entered an incorrect option. Please Try Again.");
                }
            } else if (userInput == "2")
            { 
                int pos = 0;
                Console.WriteLine("\nThe goals are:");
                foreach (Goal myGoal in goals)
                {
                    pos++;
                    myGoal.DisplayGoal(pos);
                }
            } else if (userInput == "3")
            { 
                SaveLoad saving = new SaveLoad();
                Console.WriteLine("What is the filename for the goal file? ");
                string saveFile = Console.ReadLine();
                saving.Save(saveFile, goals, points);
            } else if (userInput == "4")
            {
                SaveLoad loading = new SaveLoad();
                Console.WriteLine("What is the filename for the goal file? ");
                string loadFile = Console.ReadLine();

                goals = loading.Load(loadFile);
                points = loading.LoadPoints(loadFile);
            } else if (userInput == "5")
            {
                int pos = 0;
                
                Console.WriteLine("\nThe goals are:");
                foreach (Goal myGoal in goals)
                {
                    pos++;
                    myGoal.DisplayGoal(pos);
                }
                Console.WriteLine("\nWhich goal did you accomplish?");
                int index = Convert.ToInt32(Console.ReadLine());
                if (index-1 <= goals.Count)
                {
                    points += goals[index-1].CompleteGoal();
                    Console.WriteLine($"You now have {points} points.");
                } else
                {
                    Console.WriteLine("That isn't a current Goal, please try again.");
                }
            } else if (userInput == "6")
            {
                //ADDED points shop for Exceeding Requirements
                Console.WriteLine($"\nWelcome to the points shop, here you can spend your points:\n  1. See a Random Scripture Verse: Price 300 points\n  2. Number Guessing Game: Price 500 points\n  3. Play Tic Tac Toe: Price 1000 points\nPlease choose an option. You have {points} points remaining: ");
                string userChoice = Console.ReadLine();
                if (userChoice=="1")
                {
                    if (points < 300)
                    {
                        Console.WriteLine("Sorry! But you don't have enough points for this item!");
                    } else
                    {
                        points -=300;
                        Console.WriteLine($"\nYour points are now {points}. Thank you for your purchase! Here is your scripture:\n");
                        new RandomScriptureVerse();
                        Console.ReadLine();
                    }
                } else if (userChoice=="2")
                {
                    if (points < 500)
                    {
                        Console.WriteLine("Sorry! But you don't have enough points for this item!");
                    } else
                    {
                        points -=500;
                        Console.WriteLine($"\nYour points are now {points}. Thank you for your purchase! Press enter when you would like to start:\n");
                        Console.ReadLine();
                        new NumberGame();
                    }
                } else if (userChoice=="3")
                {
                    if (points < 1000)
                    {
                        Console.WriteLine("Sorry! But you don't have enough points for this item!");
                    } else
                    {
                        points -=1000;
                        Console.WriteLine($"\nYour points are now {points}. Thank you for your purchase! Press enter when you would like to start:\n");
                        Console.ReadLine();
                        new TicTacToe();
                    }
                } else
                {
                    Console.WriteLine("Sorry! That answer was not a choice, please try again!");
                }

            } else if (userInput == "7")
            {
                quit = true;
            } else
            {
                Console.WriteLine("\nSorry, you entered an incorrect option. Please Try Again.");
            }
        } while(!quit);
    }
}