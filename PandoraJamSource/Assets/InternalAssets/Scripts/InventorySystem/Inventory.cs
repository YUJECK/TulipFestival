using System;
using System.Collections.Generic;
using InternalAssets.Scripts.CookSystem;

namespace InternalAssets.Scripts.InventorySystem
{
    public sealed class Inventory
    {
        public List<Ingredient> Ingredients { get; } = new();

        public event Action<Ingredient> OnIngredientAdded;
        public event Action<Ingredient> OnIngredientRemoved;

        private bool IsFull => Ingredients.Count > 5;
        
        public bool AddIngredient(Ingredient ingredient)
        {
            if (IsFull)
                return false;
            
            Ingredients.Add(ingredient);

            OnIngredientAdded?.Invoke(ingredient);
            return true;
        }

        public void RemoveIngredient(Ingredient ingredient)
        {
            Ingredients.Remove(ingredient);
            OnIngredientRemoved?.Invoke(ingredient);
        }

        public bool Contains(Ingredient ingredient) 
            => Ingredients.Contains(ingredient);

        public void RemoveAll()
        {
            foreach (var ingredient in Ingredients)
                OnIngredientRemoved?.Invoke(ingredient);
            
            Ingredients.Clear();
        }
    }
}