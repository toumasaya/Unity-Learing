using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    // [SerializeField] Item knife;
    // [SerializeField] Item coin;
    [SerializeField] Item[] items;
    void Start()
    {
        // knife = new Item("Knife", 1, "This is a knife");
        // coin = GenerateItem("Coin", 2, "To buy things");
    }

    private Item GenerateItem(string name, int itemID, string description)
    {
        var item = new Item(name, itemID, description);

        return item;
    }
}
