using Presnoyarsk.Player;
using UnityEngine;

namespace InternalAssets.Scripts.CookSystem
{
    public sealed class PanInteraction : MonoBehaviour, IInteractive, IDetectable
    {
        [SerializeField] private GameObject _cookingUI;
    
        public void Interact()
        {   
            _cookingUI.SetActive(!_cookingUI.activeSelf);
        }

        public void OnDetected()
        {
            
        }

        public void OnDetectionReleased()
        {
            _cookingUI.SetActive(false);    
        }
    }
}