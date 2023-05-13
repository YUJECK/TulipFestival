using AYellowpaper.SerializedCollections;

namespace InternalAssets.Scripts.CookSystem
{
    public class MealContainer
    {
        private readonly SerializedDictionary<Recipe, Meal> _mealsRecipes = new();

        public MealContainer(SerializedDictionary<Recipe, Meal> mealsRecipes)
        {
            _mealsRecipes = mealsRecipes;
        }

        public bool Get(Recipe recipe, out Meal newMeal)
        {
            newMeal = null;
            
            foreach (var mealsRecipe in _mealsRecipes)
            {
                if (mealsRecipe.Key == recipe)
                {
                    newMeal = mealsRecipe.Value;
                    return true;
                }
            }
            
            return false;
        }
    }
}