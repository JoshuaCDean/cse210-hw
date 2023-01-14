using System;
class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        bool looping = true;
        Console.Write("Enter a list of numbers, type 0 when finished.\n");
        do
        {
            Console.Write("Enter number: ");
            int userInput = int.Parse(Console.ReadLine());
            number.Add(userInput);
            if (userInput == 0)
            {
                looping = false;
            }
        } while (looping != false);
        int sum = 0;
        int average = 0;
        int largest = -999999;
        foreach (int numero in number)
        {
            if (numero > largest)
            {
                largest = numero;
            }
            sum += numero;
        }
        average = sum/number.Count;
        Console.Write($"The sum is: {sum}\nThe average is: {average}\nThe largest number is: {largest}\n");
    }
}