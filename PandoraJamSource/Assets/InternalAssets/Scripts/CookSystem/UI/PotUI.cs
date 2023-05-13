using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.CookSystem
{
    public sealed class PotUI : MonoBehaviour
    {
        private Pot _pot;

        private Image[] _ingredientsImages;

        [SerializeField] private Image _mealSprite;

        private int _currentEmpty = 1;
        private MealContainer _mealContainer;

        [Inject]
        private void Constructor(Pot pot, MealContainer mealContainer)
        {
            _pot = pot;
            _mealContainer = mealContainer;            
            
            _pot.OnAdded += OnAdded;
            _pot.OnRemoved += OnRemoved;
        }

        private void Awake()
        {
            _ingredientsImages = GetComponentsInChildren<Image>();
        }

        private void OnRemoved(Ingredient obj)
        {
            
        }

        private void OnAdded(Ingredient obj)
        {
            _ingredientsImages[_currentEmpty].sprite = obj.IngredientSprite;
            _currentEmpty++;
        }
    }
}