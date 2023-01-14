using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromtUserName();
        int num = SquareNumber(PromptUserNumber());
        DisplayResult(name, num);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromtUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int num)
    {
        num *= num;
        return num;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, your number squared is {squared}.");
    }
}
