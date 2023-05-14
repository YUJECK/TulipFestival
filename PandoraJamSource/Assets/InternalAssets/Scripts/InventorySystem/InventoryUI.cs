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
        [SerializeField] private Slot _fourSlot;
        [SerializeField] private Slot _fifthSlot;
        
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
                _firstSlot.Set(ingredient);
                return;
            }

            if (_secondSlot.Empty)
            {
                _secondSlot.Set(ingredient);
                return;
            }

            if (_thirdSlot.Empty)
            {
                _thirdSlot.Set(ingredient);
                return;
            }
            if (_fourSlot.Empty)
            {
                _fourSlot.Set(ingredient);
                return;
            }
            if (_fifthSlot.Empty)
            {
                _fifthSlot.Set(ingredient);
                return;
            }
        }
        private void OnRemoved(Ingredient ingredient)
        {
            if (_firstSlot._current == ingredient)
            {
                _firstSlot.ResetSlot();
                return;
            }

            if (_secondSlot._current == ingredient)
            {
                _secondSlot.ResetSlot();
                return;
            }

            if (_thirdSlot._current == ingredient)
            {
                _thirdSlot.ResetSlot();
                return;
            }
            if (_fourSlot._current == ingredient)
            {
                _fourSlot.ResetSlot();
                return;
            }
            if (_fifthSlot._current == ingredient)
            {
                _fifthSlot.ResetSlot();
                return;
            }
        }
    }
}