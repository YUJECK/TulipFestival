using System.Collections.Generic;
using InternalAssets.Scripts.InputServices;
using UnityEngine;
using Zenject;

namespace Presnoyarsk.Player
{
    public sealed class Interactor : MonoBehaviour
    {
        private readonly List<IInteractive> _availableInteractions = new();
        private readonly List<IDetectable> _detectedObjects = new();

        [Inject]
        private void Constructor(IInputService service) 
            => service.OnInteracted += Interact;

        private void Interact()
        {
            foreach (var interaction in _availableInteractions)
                interaction.Interact();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out IDetectable detectable))
            {
                detectable.OnDetected();
                _detectedObjects.Add(detectable);
            }

            if (collision.TryGetComponent(out IInteractive interactive))
                _availableInteractions.Add(interactive);
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out IDetectable detectable))
            {
                if (_detectedObjects.Contains(detectable))
                {
                    detectable.OnDetectionReleased();
                    _detectedObjects.Remove(detectable);
                }
            }
            if (collision.TryGetComponent(out IInteractive interactive) && _availableInteractions.Contains(interactive))
                _availableInteractions.Remove(interactive);
        }
    }
}
