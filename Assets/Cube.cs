using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Register event - Subscribe
        Main.onTeleport += Spawn;
    }

    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
    }

    private void OnDisable()
    {
        // Unsubscribe
        Main.onTeleport -= Spawn;
    }
}
