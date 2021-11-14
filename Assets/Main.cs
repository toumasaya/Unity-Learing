using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void Teleport(Vector3 pos);
    public static event Teleport onTeleport;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onTeleport != null)
            {
                Vector3 pos = new Vector3(5, 2, 0);
                onTeleport(pos);
            }
        }
    }
}
