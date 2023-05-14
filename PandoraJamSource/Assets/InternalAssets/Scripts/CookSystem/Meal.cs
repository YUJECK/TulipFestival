using UnityEngine;

namespace InternalAssets.Scripts.CookSystem
{
    [CreateAssetMenu(menuName = "Cooking/Meal", fileName = "New Meal")]
    public sealed class Meal : ScriptableObject
    {
        [field: SerializeField] public string Name { get; set; }
        [field: SerializeField] public Sprite MealSprite { get; set; }
    }
}