using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presenter : MonoBehaviour
{
    [SerializeField] View _viewScript;

    private void OnEnable()
    {
        CoinModel.CoindAdded += CoinAdded;
    }

    private void OnDisable()
    {
        CoinModel.CoindAdded -= CoinAdded;
    }

    public void CoinAdded(int coinNumber)
    {
        _viewScript.CoinUIUpdate(coinNumber);
    }
}
