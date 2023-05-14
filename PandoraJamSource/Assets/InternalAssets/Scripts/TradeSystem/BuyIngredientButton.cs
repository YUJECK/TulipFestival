using System;
using InternalAssets.Scripts.InventorySystem;
using InternalAssets.Scripts.Player;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace InternalAssets.Scripts.TradeSystem
{
    public sealed class BuyIngredientButton : MonoBehaviour
    {
        [SerializeField] private TradeManager _tradeManager;
        
        private Button _button;
        private Inventory _inventory;
        private PlayerWallet _wallet;

        [Inject]
        private void Constructor(Inventory inventory, PlayerWallet wallet)
        {
            _inventory = inventory;
            _wallet = wallet;
        }

        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Buy); 
        }

        private void Update()
        {
            if(_tradeManager.CanBuy && _wallet.CurrentMoney >= _tradeManager.PaymentController.CurrentPayment)
                _button.enabled = true;
            else _button.enabled = false;
        }

        private void Buy()
        {
            _inventory.AddIngredient(_tradeManager.Current);
            _wallet.CurrentMoney -= _tradeManager.PaymentController.CurrentPayment; 
        }
    }
}