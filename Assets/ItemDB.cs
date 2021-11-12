using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();
    // Start is called before the first frame update
    void Start()
    {
        Item knife = new Item();
        knife.name = "Knife";
        knife.id = 0;

        Item bread = new Item();
        bread.name = "Bread";
        bread.id = 1;

        Item cape = new Item();
        cape.name = "Cape";
        cape.id = 2;

        // itemDictionary.Add(0, new Item());
        itemDictionary.Add(0, knife);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);

        foreach (KeyValuePair<int, Item> item in itemDictionary)
        {
            Debug.Log("The key: " + item.Key);
            Debug.Log("The name: " + item.Value.name);
            Debug.Log("The id: " + item.Value.id);
        }

        foreach (int key in itemDictionary.Keys)
        {
            Debug.Log("The key: " + key);
        }

        foreach (Item item in itemDictionary.Values)
        {
            Debug.Log("The name: " + item.name);
        }

        if (itemDictionary.ContainsKey(60))
        {
            Debug.Log("Found it");
        }
        else
        {
            Debug.Log("Not exsit");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
