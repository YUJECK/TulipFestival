using TMPro;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts.CookSystem.UI
{
    public sealed class IngredientAddButton : MonoBehaviour
    {
        private Ingredient _ingredient;
        private Pot _pot;

        private TMP_Text _text;
        
        [Inject]
        private void Constructor(Pot pot)
        {
            _pot = pot;
        }

        private void Awake()
        {
            _text = GetComponentInChildren<TMP_Text>();
        }

        public void SetIngredient(Ingredient ingredient)
        {
            _ingredient = ingredient;
            _text.text = ingredient.Name;
        }

        public void AddToPot()
        {
            _pot.Add(_ingredient);
        }
    }
}