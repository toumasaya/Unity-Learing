using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItemManager : MonoBehaviour
{
    // public GameItem goldCoin = new GameItem();
    public GameItem goldCoin;
    public Weapon knife = new Weapon();
    public Consumable apple = new Consumable();
    void Start()
    {
        // Using constructor
        goldCoin = new GameItem("Gold Coin", 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
