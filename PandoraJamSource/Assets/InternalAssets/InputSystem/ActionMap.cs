//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/InternalAssets/InputSystem/ActionMap.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InternalAssets.Scripts
{
    public partial class @ActionMap: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @ActionMap()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""ActionMap"",
    ""maps"": [
        {
            ""name"": ""MapMovement"",
            ""id"": ""3851017d-4be7-48e2-8212-0d14fa70afbd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e39384cd-3b8f-4e93-bdac-7143fed9855b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""61032d7d-ec5a-495c-84bd-614f619995a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DialogueNext"",
                    ""type"": ""Button"",
                    ""id"": ""a2fc96c5-f3ae-4ffb-a723-f003dcd602a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1a770095-9354-4071-91a3-249f1dbbb591"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6992c9d3-73f3-4838-a2ad-8f2d72264a03"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0058f2cb-5a78-4322-ad59-79e3f98377ee"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""394e0c80-d032-49cd-abe6-9edd2ffa8937"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e0aaf00b-329f-4bea-af01-737b6b3b3dca"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7d6a502d-1478-4492-a274-ab71306199c8"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4744ad0a-5dc8-494b-9e06-95f60357bbc2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Fighting"",
            ""id"": ""89305caa-30e1-4fce-a11d-b87067784a90"",
            ""actions"": [
                {
                    ""name"": ""RightMouseButton"",
                    ""type"": ""Button"",
                    ""id"": ""fc77d00e-5256-40d8-9b1b-cffb3e69793e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftMouseButton"",
                    ""type"": ""Button"",
                    ""id"": ""6c4d351c-ec74-410c-9405-dd6d896857b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""59a3db40-8a54-40fe-bfe2-48bdb56c3a26"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMouseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6beec0a4-ba47-426c-bd26-b5b2f2797119"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMouseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // MapMovement
            m_MapMovement = asset.FindActionMap("MapMovement", throwIfNotFound: true);
            m_MapMovement_Movement = m_MapMovement.FindAction("Movement", throwIfNotFound: true);
            m_MapMovement_Interaction = m_MapMovement.FindAction("Interaction", throwIfNotFound: true);
            m_MapMovement_DialogueNext = m_MapMovement.FindAction("DialogueNext", throwIfNotFound: true);
            // Fighting
            m_Fighting = asset.FindActionMap("Fighting", throwIfNotFound: true);
            m_Fighting_RightMouseButton = m_Fighting.FindAction("RightMouseButton", throwIfNotFound: true);
            m_Fighting_LeftMouseButton = m_Fighting.FindAction("LeftMouseButton", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // MapMovement
        private readonly InputActionMap m_MapMovement;
        private List<IMapMovementActions> m_MapMovementActionsCallbackInterfaces = new List<IMapMovementActions>();
        private readonly InputAction m_MapMovement_Movement;
        private readonly InputAction m_MapMovement_Interaction;
        private readonly InputAction m_MapMovement_DialogueNext;
        public struct MapMovementActions
        {
            private @ActionMap m_Wrapper;
            public MapMovementActions(@ActionMap wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_MapMovement_Movement;
            public InputAction @Interaction => m_Wrapper.m_MapMovement_Interaction;
            public InputAction @DialogueNext => m_Wrapper.m_MapMovement_DialogueNext;
            public InputActionMap Get() { return m_Wrapper.m_MapMovement; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MapMovementActions set) { return set.Get(); }
            public void AddCallbacks(IMapMovementActions instance)
            {
                if (instance == null || m_Wrapper.m_MapMovementActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_MapMovementActionsCallbackInterfaces.Add(instance);
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @DialogueNext.started += instance.OnDialogueNext;
                @DialogueNext.performed += instance.OnDialogueNext;
                @DialogueNext.canceled += instance.OnDialogueNext;
            }

            private void UnregisterCallbacks(IMapMovementActions instance)
            {
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @Interaction.started -= instance.OnInteraction;
                @Interaction.performed -= instance.OnInteraction;
                @Interaction.canceled -= instance.OnInteraction;
                @DialogueNext.started -= instance.OnDialogueNext;
                @DialogueNext.performed -= instance.OnDialogueNext;
                @DialogueNext.canceled -= instance.OnDialogueNext;
            }

            public void RemoveCallbacks(IMapMovementActions instance)
            {
                if (m_Wrapper.m_MapMovementActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IMapMovementActions instance)
            {
                foreach (var item in m_Wrapper.m_MapMovementActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_MapMovementActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public MapMovementActions @MapMovement => new MapMovementActions(this);

        // Fighting
        private readonly InputActionMap m_Fighting;
        private List<IFightingActions> m_FightingActionsCallbackInterfaces = new List<IFightingActions>();
        private readonly InputAction m_Fighting_RightMouseButton;
        private readonly InputAction m_Fighting_LeftMouseButton;
        public struct FightingActions
        {
            private @ActionMap m_Wrapper;
            public FightingActions(@ActionMap wrapper) { m_Wrapper = wrapper; }
            public InputAction @RightMouseButton => m_Wrapper.m_Fighting_RightMouseButton;
            public InputAction @LeftMouseButton => m_Wrapper.m_Fighting_LeftMouseButton;
            public InputActionMap Get() { return m_Wrapper.m_Fighting; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(FightingActions set) { return set.Get(); }
            public void AddCallbacks(IFightingActions instance)
            {
                if (instance == null || m_Wrapper.m_FightingActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_FightingActionsCallbackInterfaces.Add(instance);
                @RightMouseButton.started += instance.OnRightMouseButton;
                @RightMouseButton.performed += instance.OnRightMouseButton;
                @RightMouseButton.canceled += instance.OnRightMouseButton;
                @LeftMouseButton.started += instance.OnLeftMouseButton;
                @LeftMouseButton.performed += instance.OnLeftMouseButton;
                @LeftMouseButton.canceled += instance.OnLeftMouseButton;
            }

            private void UnregisterCallbacks(IFightingActions instance)
            {
                @RightMouseButton.started -= instance.OnRightMouseButton;
                @RightMouseButton.performed -= instance.OnRightMouseButton;
                @RightMouseButton.canceled -= instance.OnRightMouseButton;
                @LeftMouseButton.started -= instance.OnLeftMouseButton;
                @LeftMouseButton.performed -= instance.OnLeftMouseButton;
                @LeftMouseButton.canceled -= instance.OnLeftMouseButton;
            }

            public void RemoveCallbacks(IFightingActions instance)
            {
                if (m_Wrapper.m_FightingActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IFightingActions instance)
            {
                foreach (var item in m_Wrapper.m_FightingActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_FightingActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public FightingActions @Fighting => new FightingActions(this);
        public interface IMapMovementActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnInteraction(InputAction.CallbackContext context);
            void OnDialogueNext(InputAction.CallbackContext context);
        }
        public interface IFightingActions
        {
            void OnRightMouseButton(InputAction.CallbackContext context);
            void OnLeftMouseButton(InputAction.CallbackContext context);
        }
    }
}
