using System;

class Program
{
    static void Main(string[] args)
    {
        RecipeBook _recipeBook = new RecipeBook();
        bool quit = false;
        do 
        {
            
            Console.Clear();
            Console.WriteLine("Recipe Book Options:\n   1. Create New Recipe\n   2. View Recipe Book\n   3. Save Recipe Book\n   4. Load Recipe Book\n   5. Quit\nPlease choose an option: ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("\nWhat type of Recipe do you want to make?\n   1. Desert\n   2. Main Dish\n   3. Appetizer\nPlease Choose an Option: ");
                string recipeType = Console.ReadLine();
                if (recipeType == "1" || recipeType.ToLower() == "desert")
                {
                    Console.WriteLine("\nWhat is your Desert name?: ");
                    string desertName = Console.ReadLine();
                    Console.WriteLine("\nGive a brief description of your recipe: ");
                    string desertDesc = Console.ReadLine();
                    Desert desert = new Desert(desertName, desertDesc);
                    _recipeBook.AddRecipe(desert);

                } else if (recipeType == "2" || recipeType.ToLower() == "main dish")
                {
                    Console.WriteLine("\nWhat is your Main Dish name?: ");
                    string mainDishName = Console.ReadLine();
                    Console.WriteLine("\nGive a brief description of your recipe: ");
                    string mainDishDesc = Console.ReadLine();
                    MainDish mainDish = new MainDish(mainDishName, mainDishDesc);
                    _recipeBook.AddRecipe(mainDish);
                } else if (recipeType == "3" || recipeType.ToLower() == "appetizer")
                {
                    Console.WriteLine("\nWhat is your Appetizer name?: ");
                    string appetizerName = Console.ReadLine();
                    Console.WriteLine("\nGive a brief description of your recipe: ");
                    string appetizerDesc = Console.ReadLine();
                    Appetizer appetizer = new Appetizer(appetizerName, appetizerDesc);
                    _recipeBook.AddRecipe(appetizer);
                } else
                {
                    Console.WriteLine("Sorry that isn't an option! Please Try Agian");
                }
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