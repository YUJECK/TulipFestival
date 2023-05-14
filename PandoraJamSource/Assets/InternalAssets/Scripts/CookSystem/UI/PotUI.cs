using InternalAssets.Scripts.CookSystem.UI;
using InternalAssets.Scripts.InventorySystem;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.CookSystem
{
    public sealed class PotUI : MonoBehaviour
    {
        private Pot _pot;

        private IngredientImage[] _ingredientsImages;

        [SerializeField] private Image _mealSprite;

        private MealContainer _mealContainer;
        private Inventory _inventpry;

        [Inject]
        private void Constructor(Pot pot, MealContainer mealContainer, Inventory inventory)
        {
            _pot = pot;
            _mealContainer = mealContainer;
            _inventpry = inventory;
            
            
            _pot.OnAdded += OnAdded;
            _pot.OnRemoved += OnRemoved;
            _pot.OnCooked += OnCooked;
        }

        private void OnCooked(Meal obj)
        {
            _mealSprite.sprite = obj.MealSprite;
        }

        private void Awake()
        {
            _ingredientsImages = GetComponentsInChildren<IngredientImage>();
        }

        private void OnRemoved(Ingredient obj)
        {
            GetWith(obj)?.Remove().Disable();
        }

        private void OnAdded(Ingredient obj)
        {
            GetWith(null).SetIngredient(obj).Enable();
        }

        private IngredientImage GetWith(Ingredient ingredient)
        {
            foreach (var image in _ingredientsImages)
            {
                if (image.CurrentIngredient == ingredient)
                    return image;
            }

            return null;
        }
        
        public void TryCookButton()
        {
            if (_pot.TryCook())
            {
                foreach (var image in _ingredientsImages)
                {
                    image.Remove().Disable();
                }
                foreach (var VARIABLE in _pot.Ingredients)
                {
                    _inventpry.RemoveIngredient(VARIABLE);
                }
                _pot.RemoveAll();
                
                RemoveAll();
            }
        }

        public void RemoveAll()
        {

        }
    }
}