using InternalAssets.Scripts.CookSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace InternalAssets.Scripts.TradeSystem
{
    [RequireComponent(typeof(Button))]
    public sealed class SetIngredientButton : MonoBehaviour
    {
        private Ingredient _ingredient;
        
        private Button _button;
        private TradeManager _tradeManager;

        [SerializeField] private Image _ingredientImage;
        [SerializeField] private TMP_Text _text;
        
        public void Set(Ingredient ingredient)
        {
            if (ingredient != null)
            {
                _ingredient = ingredient;

                _ingredientImage.color = Color.white;
                
                _ingredientImage.sprite = ingredient.IngredientSprite;
                _text.text = ingredient.Name;
            }
            else
            {
                _ingredientImage.color = Color.clear;
                _text.text = "";
            }
        }

        private void Awake()
        {
            _button = GetComponent<Button>();
            
            _button.onClick.AddListener(OnClick);
        }

        private void OnClick() => _tradeManager.SetCurrent(_ingredient);
        public void SetTraderManager(TradeManager tradeManager) => _tradeManager = tradeManager;
    }
}