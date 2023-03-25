class Desert : Recipe
{

    public Desert(string name, string recipe) : base(name, recipe)
    {
        
    }
    public override string GetRecipeType()
    {
        return "Desert";
    }
}