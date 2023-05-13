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

        public bool Check()
        {
            return _mealContainer.Get(new Recipe(_currentIngredients.ToArray()), out var meal);
        }
    }
}