using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                IDamagable obj = hitInfo.collider.GetComponent<IDamagable>();
                if (obj != null)
                {
                    obj.Damage(500);
                }
                // if (hitInfo.collider.name == "Player")
                // {
                //     hitInfo.collider.GetComponent<Player>().Damage(300);
                // }
                // else if (hitInfo.collider.name == "Enemy")
                // {
                //     hitInfo.collider.GetComponent<Enemy>().Damage(300);
                // }
            }
        }
    }
}
