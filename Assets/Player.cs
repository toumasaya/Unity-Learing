using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Player only has 10 items
    public Item[] inventory = new Item[10];
    private ItemDB _itemDatabase;
    // Start is called before the first frame update
    void Start()
    {
        _itemDatabase = GameObject.Find("ItemDB").GetComponent<ItemDB>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Add Item
            _itemDatabase.AddItem(0, this);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            // Remove Item
            _itemDatabase.RemoveItem(0, this);
        }
    }
}
