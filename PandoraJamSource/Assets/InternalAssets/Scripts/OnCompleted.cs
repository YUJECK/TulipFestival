using InternalAssets.Scripts.CookSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public sealed class OnCompleted : MonoBehaviour
{
    private int completed;

    [Inject]
    private void Constructor(Pot pot)
    {
        pot.OnCooked += PotOnOnCooked;
    }

    private void PotOnOnCooked(Meal obj)
    {
        completed++;
        if (completed >= 5)
        {
            SceneManager.LoadScene(1);
        }
    }
}
