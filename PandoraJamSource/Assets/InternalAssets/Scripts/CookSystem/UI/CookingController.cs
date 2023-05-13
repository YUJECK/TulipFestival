using InternalAssets.Scripts.InventorySystem;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts.CookSystem.UI
{
    public sealed class CookingController : MonoBehaviour
    {
        private IngredientAddButton[] _buttons;

        private Inventory _inventory;

        [Inject]
        private void Constructor(Inventory inventory)
        {
            _inventory = inventory;
        }
        
        private void Awake()
        {
            _buttons = GetComponentsInChildren<IngredientAddButton>();
        }

        private void OnEnable()
        {
            int currentButton = 0;
            
            foreach (var ingredient in _inventory.Ingredients)
            {
                _buttons[currentButton].SetIngredient(ingredient.Key);
                currentButton++;
            }    
        }
    }
}