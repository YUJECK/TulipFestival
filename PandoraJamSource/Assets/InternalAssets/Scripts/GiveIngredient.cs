using InternalAssets.Scripts.CookSystem;
using InternalAssets.Scripts.InventorySystem;
using UnityEngine;
using Zenject;

namespace InternalAssets.Scripts
{
    public class GiveIngredient : MonoBehaviour
    {
        private Inventory _inventory;

        [SerializeField] private Ingredient _ingredient;
        
        [Inject]
        private void Constructor(Inventory inventory)
        {
            _inventory = inventory;
        }
        
        private void OnTriggerEnter2D(Collider2D coll) 
            => _inventory.AddIngredient(_ingredient);
    }
}