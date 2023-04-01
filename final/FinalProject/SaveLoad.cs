class SaveLoad 
{

    public RecipeBook Load(string loadFile)
    {
        RecipeBook recipeBook = new RecipeBook();
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|||");
            string recipeType = parts[1];
            string recipeName = parts[0];
            string recipeDesc = parts[2];
            string[] startIngredients = parts[3].Split("/?/");
            string[] startInstructions = parts[4].Split("/?/");
            List<Ingredients> recipeIngredients = new List<Ingredients>();
            List<string> recipeInstructions = new List<string>();
            foreach (string ingredient in startIngredients)
            {
                Ingredients ingredientAddition = new Ingredients(ingredient);
                recipeIngredients.Add(ingredientAddition);
            }

            foreach (string instruction in startInstructions)
            {
                recipeInstructions.Add(instruction);
            }

            if (recipeType == "Desert")
            {
                Desert desert = new Desert(recipeName, recipeDesc, recipeIngredients, recipeInstructions);
                recipeBook.AddRecipe(desert);
            } else if (recipeType == "Main Dish")
            {
                MainDish mainDish = new MainDish(recipeName, recipeDesc, recipeIngredients, recipeInstructions);
                recipeBook.AddRecipe(mainDish);
            } else if (recipeType == "Appetizer")
            {
                Appetizer appetizer = new Appetizer(recipeName, recipeDesc, recipeIngredients, recipeInstructions);
                recipeBook.AddRecipe(appetizer);
            }
        }

        return recipeBook;
    }

    public void Save(string saveFile, RecipeBook recipeBook)
    {
        
        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
            List<string> entries = recipeBook.ConvertRecipes();
            foreach (string entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}