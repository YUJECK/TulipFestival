using System;
using InternalAssets.Scripts.Player;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.TradeSystem
{
    [RequireComponent(typeof(Slider))]
    public sealed class PaymentController : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        public int CurrentPayment => (int)_slider.value;
        
        private Slider _slider;
        private PlayerWallet _playerWallet;

        public event Action<int> OnValueChanged;

        [Inject]
        private void Constructor(PlayerWallet playerWallet)
        {
            _playerWallet = playerWallet;
        }
        
        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _slider.onValueChanged.AddListener(OnChanged);
        }

        private void OnChanged(float arg0)
        {
            _text.text = $"{(int)arg0}$";
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