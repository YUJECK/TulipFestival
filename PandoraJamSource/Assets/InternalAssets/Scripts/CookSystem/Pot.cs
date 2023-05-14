using System;
using System.Collections.Generic;

namespace InternalAssets.Scripts.CookSystem
{
    public sealed class Pot
    {
        private readonly List<Ingredient> _currentIngredients = new();
        private readonly MealContainer _mealContainer;

        public event Action<Ingredient> OnAdded;
        public event Action<Ingredient> OnRemoved;

        public event Action<Meal> OnCooked; 

        public Ingredient[] Ingredients => _currentIngredients.ToArray();
        
        public Pot(MealContainer mealContainer)
        {
            _mealContainer = mealContainer;
        }

        public void Add(Ingredient ingredient)
        {
            _currentIngredients.Add(ingredient);
            OnAdded?.Invoke(ingredient);
        }

        public void RemoveAll()
        {
            foreach (var ingredient in _currentIngredients)
            {
                OnRemoved?.Invoke(ingredient);
            }
            _currentIngredients.Clear();
        }
        
        public bool TryCook()
        {
            if (_mealContainer.Get(new Recipe(_currentIngredients.ToArray()), out var meal))
            {
                OnCooked?.Invoke(meal);
                return true;
            }

            return false;
        }
    }
}