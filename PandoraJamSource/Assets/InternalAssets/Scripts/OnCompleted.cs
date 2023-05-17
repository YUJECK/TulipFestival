using System.Collections.Generic;
using InternalAssets.Scripts.CookSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public sealed class OnCompleted : MonoBehaviour
{
    private List<Meal> _meals = new();

    [Inject]
    private void Constructor(Pot pot) 
        => pot.OnCooked += PotOnOnCooked;

    private void PotOnOnCooked(Meal obj)
    {
        if (_meals.Contains(obj))
            return;

        _meals.Add(obj);
        
        if(_meals.Count >= 5)
            SceneManager.LoadScene(2);
    }
}
