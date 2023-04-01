abstract class Recipe
{
    private List<Ingredients> _ingredients = new List<Ingredients>();
    
    private List<string> _instructions= new List<string>();
    private string _description;
    private string _name;

    public Recipe(string name, string description)
    {
        _name = name;
        _description = description;
        CreateRecipe();
    }

    public Recipe(string name, string description, List<Ingredients> ingredients, List<string> instructions)
    {
        _name = name;
        _description = description;
        _ingredients = ingredients;
        _instructions = instructions;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public List<Ingredients> GetIngredients()
    {
        return _ingredients;
    }

    public List<string> GetInstructions()
    {
        return _instructions;
    }
    public void ViewIngredients()
    {
        Console.Clear();
        Console.WriteLine($"{_name} Ingredients: ");
        Ingredients ingredientDecoder = new Ingredients();
        List<string> ingredients = ingredientDecoder.ConvertIngredients(_ingredients);
        foreach (string ingredient in ingredients)
        {
            Console.WriteLine($"    {ingredient}");
        }
        Console.ReadLine();
    }

    public void ViewRecipe()
    {
        string type = GetRecipeType();
        Console.Clear();
        Console.WriteLine($"\n{_name} ({type}):\n\nDescription: {_description}\n\nIngredients:");
        Ingredients ingredientDecoder = new Ingredients();
        List<string> ingredients = ingredientDecoder.ConvertIngredients(_ingredients);
        foreach (string ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient}");
        }
        Console.WriteLine($"\nInstructions:");
        foreach (string instruction in _instructions)
        {
            Console.WriteLine($"{instruction}");
        }
        Console.ReadLine();
    }

    public void EditRecipe()
    {
        Console.Clear();
        Console.WriteLine("1. Edit Name\n2. Edit Description\n3. Edit Ingredients\n4. Edit Instructions\nPlease Select an option: ");
        string editOption = Console.ReadLine();
        if (editOption == "1")
        {
            Console.Clear();
            Console.WriteLine("What is the Recipe's new Name?: ");
            _name = Console.ReadLine();
        } else if (editOption == "2")
        {   
            Console.Clear();
            Console.WriteLine("What is the Recipe's new Description?: ");
            _description = Console.ReadLine();
        } else if (editOption == "3")
        {
            Console.Clear();
            Console.WriteLine("Would you like to REMOVE or ADD ingredients?: ");
            string removeAdd = Console.ReadLine();
            if (removeAdd.ToLower() == "remove")
            {
                bool removeQuit = false;
                do
                {
                    Console.Clear();
                    Ingredients ingredientConverter = new Ingredients();
                    List<string > ingredientsConverted = ingredientConverter.ConvertIngredients(_ingredients);
                    int ingredientNum = 1;
                    foreach (string ingredient in ingredientsConverted)
                    {
                        Console.WriteLine($" {ingredientNum}. {ingredient}");
                        ingredientNum += 1;
                    }
                    Console.WriteLine("Which Ingredient would you like to remove? Type QUIT if you would like to exit.");
                    string userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out _))
                    {
                        
                        int selection = Int32.Parse(userInput)-1;
                        if (selection <= _ingredients.Count)
                        {
                            _ingredients.RemoveAt(selection);
                            Console.WriteLine("Ingredient was removed!");
                            Thread.Sleep(2000);
                        }
                    } else if (userInput.ToLower() == "quit")
                    {
                        removeQuit = true;
                    } else 
                    {
                        Console.WriteLine("That isn't an option. Please try again.");
                    }
                } while (!removeQuit);
            } else if (removeAdd.ToLower() == "add")
            {
                Console.Clear();
                Console.WriteLine("Please List all the new ingredients, pressing enter after each ingredient. Type QUIT when you are finished listing the ingredients: (EX: 3 tbsp of butter or 2 Eggs)");
                bool addQuit = false;
                do
                {
                    string name = Console.ReadLine();
                    if (name.ToLower() == "quit")
                    {
                        addQuit = true;
                    }
                    else 
                    {
                        Ingredients ingredient = new Ingredients(name);
                        _ingredients.Add(ingredient);
                    }
                } while (!addQuit);

            } else
            {
                Console.WriteLine("That wasn't an option! Please try again.");
            }
            Console.ReadLine();
        } else if (editOption == "4")
        {
            Console.Clear();
            Console.WriteLine("Would you like to REMOVE or ADD Instructions?: ");
            string removeAdd = Console.ReadLine();
            if (removeAdd.ToLower() == "remove")
            {
                bool removeQuit = false;
                do
                {
                    Console.Clear();
                    int instructionNum = 1;
                    foreach (string instruction in _instructions)
                    {
                        Console.WriteLine($" {instructionNum}. {instruction}");
                        instructionNum += 1;
                    }
                    Console.WriteLine("Which Instruction would you like to remove? Type QUIT if you would like to exit.");
                    string userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out _))
                    {
                        
                        int selection = Int32.Parse(userInput)-1;
                        if (selection <= _instructions.Count)
                        {
                            _instructions.RemoveAt(selection);
                            Console.WriteLine("Instruction was removed!");
                            Console.ReadLine();
                        }
                    } else if (userInput.ToLower() == "quit")
                    {
                        removeQuit = true;
                    } else 
                    {
                        Console.WriteLine("That isn't an option. Please try again.");
                    }
                } while (!removeQuit);
            } else if (removeAdd.ToLower() == "add")
            {
                Console.Clear();
                Console.WriteLine("create the instructions for your recipe. Write a step and then hit enter to go on to the next step. Type QUIT when you are finished listing the instructions: (EX: Mix in the butter)");
                bool addQuit = false;
                do
                {
                    string name = Console.ReadLine();
                    if (name.ToLower() == "quit")
                    {
                        addQuit = true;
                    }
                    else 
                    {
                        _instructions.Add(name);
                    }
                } while (!addQuit);

            } else
            {
                Console.WriteLine("That wasn't an option! Please try again.");
            }
        } else
        {
            Console.WriteLine("Sorry that's not a correct option! Please try again.");
        }
    }

    public void CreateRecipe()
    {
        Console.WriteLine("\nPlease List all the ingredients, pressing enter after each ingredient. Type QUIT when you are finished listing the ingredients: (EX: 3 tbsp of butter or 2 Eggs)");
        bool ingredientQuit = false;
        do
        {
            string name = Console.ReadLine();
            if (name.ToLower() == "quit")
            {
                ingredientQuit = true;
            }
            else 
            {
                Ingredients ingredient = new Ingredients(name);
                _ingredients.Add(ingredient);
            }

        } while (!ingredientQuit);

        int instructionNum = 1;
        Console.WriteLine("\nNow to create the instructions for your recipe. Write a step and then hit enter to go on to the next step. Type QUIT when you are finished listing the instructions: (EX: Mix in the butter)");
        bool instructionQuit = false;
        do
        {
            Console.Write($"\nStep {instructionNum}: ");
            string newInstruction = Console.ReadLine();
            if (newInstruction.ToLower() == "quit")
            {
                instructionQuit = true;
            }
            else
            {
                _instructions.Add($"{newInstruction}");
            }
            instructionNum += 1;
        } while (!instructionQuit);
    }
    abstract public string GetRecipeType();
}