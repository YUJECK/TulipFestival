using InternalAssets.Scripts.CookSystem;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace InternalAssets.Scripts.InventorySystem
{
    public sealed class Slot : MonoBehaviour
    {
        [SerializeField] private Image image;
        public Ingredient _current;

        public bool Empty => _current == null;

        private void Awake()
        {
            //_image = GetComponentInChildren<Image>(true);
        }

        public void Set(Ingredient ingredient)
        {
            image.gameObject.SetActive(true);
            
            _current = ingredient;
            image.sprite = ingredient.IngredientSprite;
        }

        public void ResetSlot()
        {
            image.gameObject.SetActive(false);
            _current = null;
        }
    }
}