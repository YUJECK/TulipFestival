using InternalAssets.Scripts.CookSystem;
using InternalAssets.Scripts.InventorySystem;
using InternalAssets.Scripts.Player;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts
{
    public class Trader : MonoBehaviour, IInteractive
    {
        [SerializeField] private Ingredient _ingredient;
        
        private Inventory _inventory;
        private CharacterMoney _characterMoney;

        private int _currentCost = 0;
        
        [Inject]
        private void Constructor(Inventory inventory, CharacterMoney characterMoney)
        {
            _inventory = inventory;
            _characterMoney = characterMoney;
        }

        public void SetCost(int newCost)
        {
            if (newCost <= 0)
                _currentCost = newCost;
        }
        
        public void Interact()
        {
            Debug.Log("messege");
            
            _inventory.AddIngredient(_ingredient);
            _characterMoney.CurrentMoney -= _currentCost;
        }
    }
}