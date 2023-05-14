using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace InternalAssets.Scripts.TradeSystem
{
    [RequireComponent(typeof(Image))]
    public sealed class EmotionPlayer : MonoBehaviour
    {
        [SerializeField] private PaymentController _paymentController;
        [SerializeField] private Button _button;

        [SerializeField] private Vector2Int _happy;
        [SerializeField] private Vector2Int _ok;
        [SerializeField] private Vector2Int _angry;
        [SerializeField] private Vector2Int _superAngry;

        private Image _image;
        private int currentValue;
        
        private void Awake()
        {
            _paymentController.OnValueChanged += OnValueChanged;

            _image = GetComponent<Image>();
            _button.onClick.AddListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            CheckValue(currentValue);
        }

        private void OnValueChanged(int obj)
        {
            currentValue = obj;
        }

        private void CheckValue(int value)
        {
            if (InRange(value, _happy.x, _happy.y))
                _image.color = Color.green;

            if (InRange(value, _ok.x, _ok.y))
                _image.color = Color.yellow;

            if (InRange(value, _angry.x, _angry.y))
                _image.color = Color.red;

            if (InRange(value, _superAngry.x, _superAngry.y))
                _image.color = new Color(0.7f, 0.15f, 0.15f, 1);
        }

        private bool InRange(int value, int minValue, int maxValue)
        {
            if (value >= minValue && value <= maxValue)
                return true;
            return false;
        }
    }
}