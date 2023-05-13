using System;
using System.Collections.Generic;
using InternalAssets.Scripts.CookSystem;
using UnityEngine;

namespace InternalAssets.Scripts.InventorySystem
{
    public sealed class Inventory
    {
        private Dictionary<Ingredient, int> _ingredients = new();

        public event Action<Ingredient> OnIngredientAdded;
        public event Action<Ingredient> OnIngredientRemoved;

        private bool IsFull => _ingredients.Count > 3;


        public void AddIngredient(Ingredient ingredient)
        {
            if (IsFull)
                return;
            
            if (_ingredients.ContainsKey(ingredient))
                _ingredients[ingredient]++;
            else
                _ingredients.Add(ingredient, 1);

            Debug.Log("messege1");
            
            OnIngredientAdded?.Invoke(ingredient);
        }

        public void RemoveIngredient(Ingredient ingredient)
        {
            if (!_ingredients.ContainsKey(ingredient)) return;
            
            if (_ingredients[ingredient] <= 0)
            {
                _ingredients.Remove(ingredient);
                return;
            }

            _ingredients[ingredient]--;
            
            OnIngredientRemoved?.Invoke(ingredient);
        }

        public bool Contains(Ingredient ingredient) 
            => _ingredients.ContainsKey(ingredient);
    }
}