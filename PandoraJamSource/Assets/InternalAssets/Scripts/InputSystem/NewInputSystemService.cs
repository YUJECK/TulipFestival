using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace InternalAssets.Scripts.InputServices
{
    public sealed class NewInputSystemService : IInputService, ITickable
    {
        public event Action<Vector2> OnMoved;
        public event Action OnInteracted;
        public event Action OnListPressed;
        public event Action OnRightMouseButtonPressed;
        public event Action OnLeftMouseButtonPressed;

        private readonly ActionMap _inputActions;

        public NewInputSystemService()
        {
            _inputActions = new ActionMap();

            BindMapMovement();
            BindFighting();

            _inputActions.Enable();
        }

        public void Tick()
            => OnMoved?.Invoke(GetMovement());

        private void LeftMouseButton_performed(InputAction.CallbackContext obj) 
            => OnLeftMouseButtonPressed?.Invoke();

        private void RightMouseButton_performed(InputAction.CallbackContext obj)
            => OnRightMouseButtonPressed?.Invoke();

        private void DialogueNext_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
            => OnListPressed?.Invoke();

        private void Interaction_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
            => OnInteracted?.Invoke();

        private Vector2 GetMovement() 
            => _inputActions.MapMovement.Movement.ReadValue<Vector2>();

        private void BindFighting()
        {
            _inputActions.Fighting.RightMouseButton.performed += RightMouseButton_performed;
            _inputActions.Fighting.LeftMouseButton.performed += LeftMouseButton_performed;
        }

        private void BindMapMovement()
        {
            _inputActions.MapMovement.Interaction.performed += Interaction_performed;
            _inputActions.MapMovement.DialogueNext.performed += DialogueNext_performed;
        }
    }
}