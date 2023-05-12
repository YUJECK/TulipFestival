using AYellowpaper.SerializedCollections;

namespace InternalAssets.Scripts.CookSystem
{
    public class MealContainer
    {
        private readonly SerializedDictionary<Ingredient[], Meal> _mealsRecipes = new();

        public MealContainer(SerializedDictionary<Ingredient[], Meal> mealsRecipes)
        {
            _mealsRecipes = mealsRecipes;
        }

        public Meal Get(Ingredient[] ingredients)
        {
            _mealsRecipes.TryGetValue(ingredients, out Meal meal);

            return meal;
        }
    }
}