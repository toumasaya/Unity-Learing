using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        // UtilityHelper.CreateCubeObject();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UtilityHelper.SetPostionToZero(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            UtilityHelper.ChangeObjColor(this.gameObject, Color.red, true);
        }
    }
}
