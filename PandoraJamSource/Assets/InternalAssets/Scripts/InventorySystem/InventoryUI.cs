using InternalAssets.Scripts.CookSystem;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts.InventorySystem
{
    public sealed class InventoryUI : MonoBehaviour
    {
        private Inventory _inventory;
        
        [SerializeField] private Slot _firstSlot;
        [SerializeField] private Slot _secondSlot;
        [SerializeField] private Slot _thirdSlot;
        
        [Inject]
        private void Constructor(Inventory inventory)
        {
            _inventory = inventory;
                
            _inventory.OnIngredientAdded += OnAdded;
            _inventory.OnIngredientRemoved += OnRemoved;
        }

        private void OnAdded(Ingredient ingredient)
        {
            if (_firstSlot.Empty)
            {
                
                Debug.Log("messege2");
                
                _firstSlot.Set(ingredient);
                return;
            }

            if (_secondSlot.Empty)
            {
                _firstSlot.Set(ingredient);
                return;
            }

            if (_thirdSlot.Empty)
            {
                _firstSlot.Set(ingredient);
                return;
            }
        }
        private void OnRemoved(Ingredient ingredient)
        {
            
        }
    }
}