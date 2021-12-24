using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Item : MonoBehaviour
{
    [SerializeField] private CoinModel _coinModel;
    [SerializeField] private ItemColor _itemColor;
    ObjectPool<Item> _pool;

    public void SetPool(ObjectPool<Item> pool) => _pool = pool;

    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = _itemColor.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        _coinModel.AddCoin();
        _pool.Release(this);
    }
}
