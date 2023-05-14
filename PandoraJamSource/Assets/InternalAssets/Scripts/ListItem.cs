using InternalAssets.Scripts.CookSystem;
using UnityEngine;

[System.Serializable]
public sealed class ListItem
{
    [field: SerializeField] public Meal Meal { get; private set; }
    [field: SerializeField] public Ingredient[] Ingredients { get; private set; }

    public ListItem(Meal meal, Ingredient[] ingredients)
    {
        Meal = meal;
        Ingredients = ingredients;
    }

    public string GetMealName()
    {
        return Meal.Name;
    }

    public string GetIngredientsNames()
    {
        string ingredients = "";
        
        foreach (var ingredient in Ingredients)
        {
            ingredients += ingredient.Name + "\n";
        }

        return ingredients;
    }
}