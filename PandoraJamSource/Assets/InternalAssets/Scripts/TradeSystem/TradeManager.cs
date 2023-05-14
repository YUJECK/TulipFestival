using System;
using InternalAssets.Scripts.CookSystem;
using UnityEngine;
using UnityEngine.Serialization;

namespace InternalAssets.Scripts.TradeSystem
{
    public sealed class TradeManager : MonoBehaviour
    {
        private Ingredient _currentIngredient;

        [FormerlySerializedAs("_PaymentController")] public PaymentController PaymentController;
        
        public bool CanBuy { get; set; } = false;
        
        public event Action<Ingredient> OnIngredientChanged;

        public Ingredient Current => _currentIngredient;
        
        public void SetCurrent(Ingredient ingredient)
        {
            if (ingredient != null)
                _currentIngredient = ingredient;
            
            OnIngredientChanged?.Invoke(ingredient);
        }
    }
}