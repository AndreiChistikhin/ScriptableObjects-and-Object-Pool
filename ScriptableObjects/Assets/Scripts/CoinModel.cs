using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Collection")]
public class CoinModel : ScriptableObject
{
    int _coinNumber;

    public static event Action<int> CoindAdded;

    public void AddCoin()
    {
        _coinNumber++;
        CoindAdded?.Invoke(_coinNumber);
    }
}
