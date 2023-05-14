using System;
using System.Collections.Generic;
using InternalAssets.Scripts.CookSystem;
using InternalAssets.Scripts.InputServices;
using Unity.Mathematics;
using UnityEngine;
using Zenject;

public class CookList : MonoBehaviour
{
    [SerializeField] private ListItem[] _items;
    [SerializeField] private List<ListItemObject> _itemObjects = new();
    [SerializeField] private ListItemObject itemPrefab;

    [SerializeField] private ListItemObject _first;
    [SerializeField] private GameObject _list;
    [SerializeField] private Vector3 move;

    public event Action OnAllCompleted; 

    [Inject]
    private void Constructor(Pot service, IInputService inputService)
    {
        service.OnCooked += OnCooked;
        inputService.OnListPressed += EnableList;
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
        _first.Set(_items[0]);
        _itemObjects.Add(_first);

        for (var index = 1; index < _items.Length; index++)
        {
            var item = _items[index];

            Vector3 newPos = _first.transform.position + move * index;
            ListItemObject itemObject = Instantiate(itemPrefab, newPos, quaternion.identity, _list.transform);
            _itemObjects.Add(itemObject);

            itemObject.Set(item);
        }
    }
}