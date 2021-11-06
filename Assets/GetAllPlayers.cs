using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAllPlayers : MonoBehaviour
{
    public GameObject[] players;
    void Start()
    {
        players = GetAllCustomPlayers();
    }

    // Update is called once per frame
    void Update()
    {

    }

    GameObject[] GetAllCustomPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

        foreach (var p in allPlayers)
        {
            p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        return allPlayers;
    }
}
