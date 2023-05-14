using System;
using InternalAssets.Scripts.TradeSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class TraderSwitchController : MonoBehaviour
{
    [SerializeField] private Image _traderImage;
    [SerializeField] private TMP_Text _text;

    [SerializeField] private IngredientButtonBinder _ingredientButtonBinder;

    [SerializeField] private TraderConfig test;
    
    private void Start()
    {
        Switch(test);
    }

    public void Switch(TraderConfig traderConfig)
    {
        _text.text = traderConfig.Name;
        _traderImage.sprite = traderConfig.OkSprite;
        
        _ingredientButtonBinder.SetIngredients(traderConfig.Ingredients);
    }
}