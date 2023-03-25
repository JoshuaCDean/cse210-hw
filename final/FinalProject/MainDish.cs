class MainDish : Recipe
{
    public MainDish(string name, string recipe) : base(name, recipe)
    {
        
    }
    public override string GetRecipeType()
    {
        return "MainDish";
    }
}