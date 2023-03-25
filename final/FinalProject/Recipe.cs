abstract class Recipe
{
    private List<Ingredients> _ingredients = new List<Ingredients>();
    private string _description;
    private string _name;

    public Recipe(string name, string description)
    {
        _name = name;
        _description = description;
    }
    abstract public string GetRecipeType();
}