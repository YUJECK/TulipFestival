using System;
using InternalAssets.Scripts.CookSystem;
using UnityEngine;

namespace InternalAssets.Scripts.TradeSystem
{
    public sealed class TradeManager : MonoBehaviour
    {
        private Ingredient _currentIngredient;

        public event Action<Ingredient> OnIngredientChanged;
        
        public void SetCurrent(Ingredient ingredient)
        {
            if (ingredient != null)
                _currentIngredient = ingredient;
        }
    }
}