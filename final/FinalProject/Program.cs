using System;

class Program
{
    static void Main(string[] args)
    {
        RecipeBook _recipeBook = new RecipeBook();
        Console.Clear();
        bool quit = false;
        do 
        {
            Console.WriteLine("Options:\n   1. Create New Recipe\n   2. View Recipe Book\n   3. Save Recipe Book\n   4. Load Recipe Book\n   5. Quit\nPlease choose an option: ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("What type of Recipe do you want to make?\n   1. Desert\n   2. Main Dish\n   3. Appetizer\nPlease Choose an Option: ");

                string recipeType = Console.ReadLine();
            } else if (userInput == "2")
            {
                _recipeBook.DisplayRecipes();
            } else if (userInput == "3")
            {
                Console.WriteLine("What is the filename? (EX: recipes.txt): ");
                string saveFile = Console.ReadLine();
                SaveLoad save = new SaveLoad();
                save.Save(saveFile, _recipeBook);
            } else if (userInput == "4")
            {   
                Console.WriteLine("What is the filename? (EX: recipes.txt): ");
                string loadFile = Console.ReadLine();
                SaveLoad load = new SaveLoad();
                _recipeBook = load.Load(loadFile);
            } else if (userInput == "5")
            {
                quit = true;
            } else
            {
                Console.WriteLine("Sorry that wasn't a choice, Please try again!");
            }
        } while (!quit);
    }
}