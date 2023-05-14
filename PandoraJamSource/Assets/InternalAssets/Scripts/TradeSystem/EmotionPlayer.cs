using InternalAssets.Scripts.CookSystem;
using UnityEngine;
using UnityEngine.UI;

namespace InternalAssets.Scripts.TradeSystem
{
    [RequireComponent(typeof(Image))]
    public sealed class EmotionPlayer : MonoBehaviour
    {
        [SerializeField] private TraderSwitchController _traderSwitchController;
        [SerializeField] private TradeManager _traderManager;
        [SerializeField] private PaymentController _paymentController;
        [SerializeField] private Button _button;

        [SerializeField] private Vector2Int _happy => _ingredient.Happy;
        [SerializeField] private Vector2Int _ok => _ingredient.Ok;
        [SerializeField] private Vector2Int _angry => _ingredient.Angry;
        [SerializeField] private Vector2Int _superAngry => _ingredient.SuperAngry;

        private Ingredient _ingredient;
        
        private Image _image;
        private int currentValue;

        private TraderConfig _config;
        
        private void Awake()
        {
            _paymentController.OnValueChanged += OnValueChanged;

            _image = GetComponent<Image>();
            _button.onClick.AddListener(OnButtonClick);
            _traderSwitchController.OnTraderSwitched += OnTraderSwitched;
            _traderManager.OnIngredientChanged += OnIngredientChanged;
        }

        private void OnIngredientChanged(Ingredient obj)
        {
            _ingredient = obj;
        }

        private void OnTraderSwitched(TraderConfig obj)
        {
            _config = obj;
        }

        private void OnButtonClick()
        {
            CheckValue(currentValue);
        }

        private void OnValueChanged(int obj)
        {
            currentValue = obj;
            
            if (InRange(obj, _happy.x, _happy.y))
                _traderManager.CanBuy = true;

            if (InRange(obj, _ok.x, _ok.y))
                _traderManager.CanBuy = true;

            
            if (InRange(obj, _angry.x, _angry.y))
                _traderManager.CanBuy = false;

            if (InRange(obj, _superAngry.x, _superAngry.y))
                _traderManager.CanBuy = false;
        }

        private void CheckValue(int value)
        {
            if (InRange(value, _happy.x, _happy.y))
            {
                _image.sprite = _config.HappySprite;
                _traderManager.CanBuy = true;
            }

            if (InRange(value, _ok.x, _ok.y))
            {
                _image.sprite = _config.OkSprite;
                _traderManager.CanBuy = true;
            }

            if (InRange(value, _angry.x, _angry.y))
            {
                _image.sprite = _config.AngrySprite;
                _traderManager.CanBuy = false;
            }

            if (InRange(value, _superAngry.x, _superAngry.y))
            {
                _image.sprite = _config.SuperAngrySprite;
                _traderManager.CanBuy = false;
            }
        }

        private bool InRange(int value, int minValue, int maxValue)
        {
            if (value >= minValue && value <= maxValue)
                return true;
            return false;
        }
    }
}