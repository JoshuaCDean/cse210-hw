class Appetizer : Recipe
{

    public Appetizer(string name, string recipe) : base(name, recipe)
    {
        
    }
    public override string GetRecipeType()
    {
        return "Appetizer";
    }
}