using InternalAssets.Scripts.TradeSystem;
using Presnoyarsk.Player;
using UnityEngine;

namespace InternalAssets.Scripts
{
    public class Trader : MonoBehaviour, IInteractive, IDetectable
    {
        [SerializeField] private TraderSwitchController _tradeUI;
        [SerializeField] private TraderConfig _traderConfig;
        
        public void Interact()
        {
            _tradeUI.gameObject.SetActive(true);
            _tradeUI.Switch(_traderConfig);
        }

        public void OnDetected()
        {
            
        }

        public void OnDetectionReleased()
        {
            _tradeUI.gameObject.SetActive(false);
        }
    }
}