class RecipeBook
{
    private List<Recipe> _recipeBook = new List<Recipe>(); 

    public void AddRecipe(Recipe recipe)
    {
        _recipeBook.Add(recipe);
    }

    public void DeleteRecipe(int number)
    {
        _recipeBook.RemoveAt(number);
    }

    public void DisplayRecipes()
    {
        Console.Clear();
        Console.WriteLine("Here are your recipes:");
        int instructionNum = 1;
        foreach (Recipe recipe in _recipeBook)
        {
            string name = recipe.GetName();
            string type = recipe.GetRecipeType();
            Console.WriteLine($"   {instructionNum}. {name} ({type})");
            instructionNum += 1;
        }
        Console.WriteLine("\nYou can select a Recipe to view more options: ");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out _))
        {
            int selection = Int32.Parse(userInput)-1;
            if ( selection <= _recipeBook.Count())
            {
                Recipe chosenRecipe = _recipeBook[selection];
                Console.WriteLine($"\nRecipe: {chosenRecipe.GetName()}\n   1. View Ingredients\n   2. View Full Recipe\n   3. Edit Recipe\n   4. Delete Recipe");
                string recipeOption = Console.ReadLine();
                if (recipeOption == "1")
                {
                    chosenRecipe.ViewIngredients();
                } else if (recipeOption == "2")
                {
                    chosenRecipe.ViewRecipe();
                } else if (recipeOption == "3")
                {
                    chosenRecipe.EditRecipe();
                } else if (recipeOption == "4")
                {
                    DeleteRecipe(selection);
                } else
                {
                    Console.WriteLine("That isn't an option please try again.");
                }
            }
        }
    }

    public List<string> ConvertRecipes()
    {
        List<string> recipeList = new List<string>();
        foreach (Recipe recipe in _recipeBook)
        {
            string name = recipe.GetName();
            string type = recipe.GetRecipeType();
            string description = recipe.GetDescription();
            List<Ingredients> ingredients = recipe.GetIngredients();
            List<string> instructions = recipe.GetInstructions();
            string entry = $"{name}|||{type}|||{description}|||";
            foreach (Ingredients ingredient in ingredients)
            {
                entry = entry + ingredient.ConvertIngredient() + "/?/";
            }
            entry = entry + "|||";
            foreach (string instruction in instructions)
            {
                entry = entry + instruction + "/?/";
            }
            recipeList.Add(entry);
        }
        return recipeList;
    }
}