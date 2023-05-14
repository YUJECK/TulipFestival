using UnityEngine;
using UnityEngine.UI;

namespace InternalAssets.Scripts.CookSystem.UI
{
    [RequireComponent(typeof(Image))]
    public sealed class IngredientImage : MonoBehaviour
    {
        public Ingredient CurrentIngredient { get; private set; }

        public IngredientImage SetIngredient(Ingredient ingredient)
        {
            CurrentIngredient = ingredient;
            GetComponent<Image>().sprite = ingredient.IngredientSprite;

            return this;
        }

        public IngredientImage Enable()
        {
            GetComponent<Image>().color = Color.white;
            return this;
        }

        public IngredientImage Disable()
        {
            GetComponent<Image>().color = Color.clear;
            return this;
        }
        public IngredientImage Remove()
        {
            CurrentIngredient = null;
            return this;
        }
    }
}