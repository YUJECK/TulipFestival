using InternalAssets.Scripts.CookSystem;
using UnityEngine;
using UnityEngine.UI;

namespace InternalAssets.Scripts.TradeSystem
{
    [CreateAssetMenu]
    public sealed class TraderConfig : ScriptableObject
    {
        [field: SerializeField] public string Name{ get; private set; }
        
        [field: SerializeField] public Sprite OkSprite { get; private set; }
        [field: SerializeField] public Sprite HappySprite { get; private set; }
        [field: SerializeField] public Sprite AngrySprite { get; private set; }
        [field: SerializeField] public Sprite SuperAngrySprite { get; private set; }
        
        [field: SerializeField] public Ingredient[] Ingredients { get; private set; }
    }
}