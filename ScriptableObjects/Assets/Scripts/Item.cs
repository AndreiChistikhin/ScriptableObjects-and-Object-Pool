using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private CoinModel _coinModel;
    [SerializeField] private ItemColor _itemColor;

    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = _itemColor.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        _coinModel.AddCoin();
        Destroy(gameObject);
    }
}
