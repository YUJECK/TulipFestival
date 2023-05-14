using InternalAssets.Scripts.CookSystem;
using UnityEngine;

namespace InternalAssets.Scripts.TradeSystem
{
    public sealed class IngredientButtonBinder : MonoBehaviour
    {
        private SetIngredientButton[] _setIngredientButton;
        [SerializeField] private TradeManager _tradeManager;

        private void Awake()
        {
            _setIngredientButton = GetComponentsInChildren<SetIngredientButton>();

            foreach (var button in _setIngredientButton)
            {
                button.SetTraderManager(_tradeManager);
            }
        }

        public void SetIngredients(Ingredient[] ingredients)
        {
            for (var index = 0; index < _setIngredientButton.Length; index++)
            {
                if (index >= ingredients.Length)
                {
                    _setIngredientButton[index].Set(null);
                    continue;
                }
                
                var ingredient = ingredients[index];
                _setIngredientButton[index].Set(ingredient);
            }
        }
    }
}