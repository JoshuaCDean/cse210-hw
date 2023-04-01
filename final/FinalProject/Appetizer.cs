class Appetizer : Recipe
{

    public Appetizer(string name, string description) : base(name, description)
    {
        
    }

    public Appetizer(string name, string description, List<Ingredients> ingredients, List<string> instructions) : base(name, description, ingredients, instructions)
    {
        
    }
    public override string GetRecipeType()
    {
        return "Appetizer";
    }
}