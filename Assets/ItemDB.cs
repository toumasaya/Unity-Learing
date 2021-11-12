using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemType = new List<Item>();
    // Start is called before the first frame update
    void Start()
    {
        itemType[0].Action();
    }
}
