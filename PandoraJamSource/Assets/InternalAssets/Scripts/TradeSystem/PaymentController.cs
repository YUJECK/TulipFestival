using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace InternalAssets.Scripts.TradeSystem
{
    [RequireComponent(typeof(Slider))]
    public sealed class PaymentController : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        
        private Slider _slider;

        public event Action<int> OnValueChanged;
        
        private void Awake()
        {
            _slider = GetComponent<Slider>();
            
            _slider.onValueChanged.AddListener(OnChanged);
        }

        private void OnChanged(float arg0)
        {
            _text.text = $"{arg0}$";
            OnValueChanged?.Invoke((int)arg0);
        }

        private void Enable(int maxPayment)
        {
            _slider.maxValue = maxPayment;
        }
        private void Disable(int maxPayment)
        {
            _slider.maxValue = maxPayment;
        }
    }
}