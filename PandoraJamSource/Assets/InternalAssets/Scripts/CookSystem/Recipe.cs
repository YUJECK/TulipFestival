using System;
using System.Collections.Generic;

namespace InternalAssets.Scripts.CookSystem
{
    [Serializable]
    public sealed class Recipe
    {
        public List<Ingredient> Ingredients;
        
        public Recipe(Ingredient[] ingredients)
        {
            Ingredients = new(ingredients);
        }        
        
        public static bool operator ==(Recipe recipe1, Recipe recipe2)
        {
            foreach (var ingredient in recipe1.Ingredients)
            {
                if (!recipe2.Ingredients.Contains(ingredient))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(Recipe recipe1, Recipe recipe2)
        {
            foreach (var ingredient in recipe1.Ingredients)
            {
                if (!recipe2.Ingredients.Contains(ingredient))
                    return true;
            }

            return false;
        }
    }
}