using System;
using System.Collections.Generic;
using InternalAssets.Scripts.CookSystem;

namespace InternalAssets.Scripts.InventorySystem
{
    public sealed class Inventory
    {
        public Dictionary<Ingredient, int> Ingredients { get; } = new();

        public event Action<Ingredient> OnIngredientAdded;
        public event Action<Ingredient> OnIngredientRemoved;

        private bool IsFull => Ingredients.Count > 3;
        
        public bool AddIngredient(Ingredient ingredient)
        {
            if (IsFull)
                return false;
            
            if (Ingredients.ContainsKey(ingredient))
                Ingredients[ingredient]++;
            else
                Ingredients.Add(ingredient, 1);

            OnIngredientAdded?.Invoke(ingredient);
            return true;
        }

        public void RemoveIngredient(Ingredient ingredient)
        {
            if (!Ingredients.ContainsKey(ingredient)) return;
            
            if (Ingredients[ingredient] <= 0)
            {
                Ingredients.Remove(ingredient);
                return;
            }

            Ingredients[ingredient]--;
            
            OnIngredientRemoved?.Invoke(ingredient);
        }

        public bool Contains(Ingredient ingredient) 
            => Ingredients.ContainsKey(ingredient);
    }
}