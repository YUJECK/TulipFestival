using System;
using UnityEngine;

namespace InternalAssets.Scripts.InputServices
{
    public interface IInputService
    {
        event Action<Vector2> OnMoved;
        event Action OnInteracted;
        event Action OnDialoguePressed;
        event Action OnRightMouseButtonPressed;
        event Action OnLeftMouseButtonPressed;
    }
}   