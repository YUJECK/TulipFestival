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
            
            _inventory.OnIngredientAdded += UpdateSlots;
        }

        private void UpdateSlots(Ingredient obj)
        {            
            int currentButton = 0;
            
            foreach (var ingredient in _inventory.Ingredients)
            {
                _buttons[currentButton].SetIngredient(ingredient);
                currentButton++;
            }    
        }

        private void Awake()
        {
            _buttons = GetComponentsInChildren<IngredientAddButton>();
        }

        private void OnEnable()
        {
            UpdateSlots(null);
        }
    }
}