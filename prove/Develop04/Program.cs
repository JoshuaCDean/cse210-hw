using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n  1. Start Breathing Activity\n  2. Start Reflecting Activity\n  3. Start Listing Activity\n  4. Time Tracker\n  5. Quit\nSelect a choice from the menu: ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This Activity will help you relax by walking you trhough breathing in and out slowly. Clear your mind and focus on your breathing.");
            } else if (userInput == "2")
            {
                ReflectingActivity reflection = new ReflectingActivity("Reflecting Activity", "This activity will help you refelct on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            } else if (userInput == "3")
            {
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            }
            else if (userInput == "4")
            {

                //Exceeding Requirements New Time Tracker that stores all the time spent on each activity in seperate files and then when asked adds up the time and displays it for the user to see.
                TimeTracker timeDisplay = new TimeTracker();
                timeDisplay.DisplayTimes();
            } else if (userInput == "5")
            {
                quit= true;
            } else
            {
                Console.WriteLine("I'm sorry you're choice wasn't an option! Please try again");
            };
        } while (!quit);
    }
}