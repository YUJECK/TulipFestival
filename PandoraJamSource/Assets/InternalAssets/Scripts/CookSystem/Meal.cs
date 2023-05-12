using UnityEngine;

namespace InternalAssets.Scripts.CookSystem
{
    [CreateAssetMenu(menuName = "Cooking/Meal", fileName = "New Meal")]
    public sealed class Meal : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public Sprite IngredientSprite { get; private set; }
    }
}