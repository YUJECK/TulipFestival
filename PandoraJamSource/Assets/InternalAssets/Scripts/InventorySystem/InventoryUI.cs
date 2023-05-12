using System.Net.Mime;
using InternalAssets.Scripts.CookSystem;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.InventorySystem
{
    public sealed class InventoryUI : MonoBehaviour
    {
        private Inventory _inventory;

        [SerializeField] private Image _slot;
        
        [Inject]
        private void Constructor(Inventory inventory)
        {
            _inventory = inventory;
                
            _inventory.OnIngredientAdded += OnAdded;
            _inventory.OnIngredientRemoved += OnRemoved;
        }

        private void OnAdded(Ingredient ingredient)
        {
            _slot.gameObject.SetActive(true);
            _slot.sprite = ingredient.IngredientSprite;
        }
        private void OnRemoved(Ingredient ingredient)
        {
            _slot.gameObject.SetActive(false);
        }
    }
}