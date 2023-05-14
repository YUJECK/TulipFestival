using System.Collections;
using System.Collections.Generic;
using InternalAssets.Scripts.Player;
using TMPro;
using UnityEngine;
using Zenject;

public class WalletUI : MonoBehaviour
{
    private PlayerWallet _service;

    [Inject]
    private void Constructor(PlayerWallet service)
    {
        _service = service;
    }
    
    void Update()
    {
        GetComponent<TMP_Text>().text = _service.CurrentMoney + "$";            
    }
}
