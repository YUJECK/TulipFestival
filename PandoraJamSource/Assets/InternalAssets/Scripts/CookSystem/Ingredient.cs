using UnityEngine;
using UnityEngine.Serialization;

namespace InternalAssets.Scripts.CookSystem
{
    [CreateAssetMenu(menuName = "Cooking/Ingredient", fileName = "New Ingredient")]
    public sealed class Ingredient : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public Sprite IngredientSprite { get; private set; }

        [field: SerializeField] public Vector2Int Happy { get; private set; }
        [field: SerializeField] public  Vector2Int Ok { get; private set; }
        [field: SerializeField] public  Vector2Int Angry { get; private set; }
        [field: SerializeField] public  Vector2Int SuperAngry { get; private set; }
    }
}