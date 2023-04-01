class Ingredients
{

    private string _name;
    public Ingredients(string name)
    {
        _name = name;
    }

    public Ingredients(){}
    public List<string> ConvertIngredients(List<Ingredients> ingredients)
    {
        List<string> convertedIngredients = new List<string>();
        foreach (Ingredients ingredient in ingredients)
        {
            convertedIngredients.Add(ingredient._name);
        }
        return convertedIngredients;
    }

    public string ConvertIngredient()
    {
        return _name;
    }
}