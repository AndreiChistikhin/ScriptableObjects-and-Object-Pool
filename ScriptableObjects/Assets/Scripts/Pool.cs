using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Pool : MonoBehaviour
{
    [SerializeField] private Item _item;
    ObjectPool<Item> _pool;

    private void Awake()
    {
        _pool = new ObjectPool<Item>(CreateItem,null,ReleaseItem);
    }

    public void Update()
    {
        Item item = _pool.Get();
    }

    Item CreateItem()
    {
        Item item=Instantiate(_item);
        item.SetPool(_pool);
        return item;
    }

    public void GetItem(Item item)
    {
        item.gameObject.SetActive(true);
    }

    public void ReleaseItem(Item item)
    {
        Destroy(item.gameObject);
    }
}
