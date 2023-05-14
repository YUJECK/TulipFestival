using System;
using System.Collections.Generic;
using InternalAssets.Scripts.CookSystem;
using InternalAssets.Scripts.InputServices;
using Unity.Mathematics;
using UnityEngine;
using Zenject;

public class CookList : MonoBehaviour
{
    [SerializeField] private List<ListItemObject> _itemObjects = new();
    [SerializeField] private ListItemObject itemPrefab;

    [SerializeField] private ListItemObject _first;
    [SerializeField] private GameObject _list;
    [SerializeField] private Vector3 move;

    public event Action OnAllCompleted;

    private MealContainer _mealContainer;
    
    [Inject]
    private void Constructor(Pot service, IInputService inputService, MealContainer mealContainer)
    {
        service.OnCooked += OnCooked;
        inputService.OnListPressed += EnableList;
        _mealContainer = mealContainer;

    }

    private void EnableList()
    {
        _list.SetActive(!_list.activeSelf);
    }

    private void OnCooked(Meal obj)
    {
        foreach (var item in (_itemObjects))
        {
            if(item.Meal == obj)
                item.Complete();
        }

        foreach (var variable in _itemObjects)
        {
            if(!variable.Completed)
                return; 
        }

        OnAllCompleted?.Invoke();
    }

    private void Awake()
    {
        int index = 0;
        
        foreach (var meal in _mealContainer._mealsRecipes)
        {
            if (index == 0)
            {
                _first.Set(new ListItem(meal.Value, meal.Key.Ingredients.ToArray()));
                _itemObjects.Add(_first);
            }

            else
            {
                Vector3 newPos = _first.transform.position + move * index;
                ListItemObject itemObject = Instantiate(itemPrefab, newPos, quaternion.identity, _list.transform);
                _itemObjects.Add(itemObject);

                itemObject.Set(new ListItem(meal.Value, meal.Key.Ingredients.ToArray()));
            }
            index++;
        }
    }
}