using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseWeapon : MonoBehaviour
{
    public int weaponID;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (weaponID)
        {
            case 1:
                Debug.Log("Gun");
                break;
            case 2:
                Debug.Log("Knife");
                break;
            case 3:
                Debug.Log("Machine Gun");
                break;
            default:
                Debug.Log("Nothing");
                break;
        }
    }
}
