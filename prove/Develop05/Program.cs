using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        List<Goal> goals = new List<Goal>();
        do
        {

            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3.Checklist Goal\nWhich type of goal would you like to create?: ");
                string goalChoice = Console.ReadLine();
                if (goalChoice == "1")
                {
                    Console.WriteLine("What is the name of your goal?: ");
                    string myGoal = Console.ReadLine();
                    Console.WriteLine("What is the amount of points for this goal?");
                    double myPoints = Convert.ToInt32(Console.ReadLine());
                    SimpleGoal newGoal = new SimpleGoal(myPoints, myGoal);
                    goals.Add(newGoal);
                } else if (goalChoice == "2")
                {
                    Console.WriteLine("What is the name of your goal?: ");
                    string myGoal = Console.ReadLine();
                    Console.WriteLine("What is the amount of points for this goal?");
                    double myPoints = Convert.ToInt32(Console.ReadLine());
                    EternalGoal newGoal = new EternalGoal(myPoints, myGoal);
                    goals.Add(newGoal);
                } else if (goalChoice == "3")
                {
                    Console.WriteLine("What is the name of your goal?: ");
                    string myGoal = Console.ReadLine();
                    Console.WriteLine("What is the amount of points for this goal?");
                    double myPoints = Convert.ToInt32(Console.ReadLine());
                    ChecklistGoal newGoal = new ChecklistGoal(myPoints, myGoal);
                    goals.Add(newGoal);
                } else
                {
                    Console.WriteLine("Sorry you entered an incorrect option. Please Try Again.");
                }
            } else if (userInput == "2")
            { 
                int pos = 0;
                foreach (Goal myGoal in goals)
                {
                    pos++;
                    myGoal.DisplayGoal(pos);
                }
            } else if (userInput == "3")
            { 
 
            } else if (userInput == "4")
            { 
 
            } else if (userInput == "5")
            { 
 
            } else if (userInput == "6")
            {

            } else
            {
                Console.WriteLine("Sorry, you entered an incorrect option. Please Try Again.");
            }
        } while(!quit);
    }
}