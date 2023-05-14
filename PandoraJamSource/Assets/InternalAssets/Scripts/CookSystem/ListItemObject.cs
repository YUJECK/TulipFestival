using TMPro;
using UnityEngine;

namespace InternalAssets.Scripts.CookSystem
{
    public sealed class ListItemObject : MonoBehaviour
    {
        public TMP_Text _mealText;
        public TMP_Text _ingredientText;
        
        public Meal Meal;
        
        public bool Completed = false;
        
        public void Set(ListItem listItem)
        {
            _mealText.text = listItem.GetMealName();
            _ingredientText.text = listItem.GetIngredientsNames();
            Meal = listItem.Meal;

        }
        
        
        public void Complete()
        {
            _mealText.text = $"<s>{_mealText.text}<s>";
            Completed = true;
        }
    }
}