using TMPro;
using UnityEditor;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts.CookSystem.UI
{
    public sealed class IngredientAddButton : MonoBehaviour
    {
        public Ingredient Ingredient { get; private set; }
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
            Ingredient = ingredient;
            
            if (ingredient == null)
            {
                Disable();
                return;
            }
            
            _text.text = ingredient.Name;
        }

        private void Disable()
        {
            _text.text = "";
        }

        public void AddToPot()
        {
            if(Ingredient != null)
                _pot.Add(Ingredient);
        }
    }
}