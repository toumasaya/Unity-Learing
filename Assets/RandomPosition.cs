using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public Vector3[] posArray;
    void Start()
    {
        // Debug.Log(posArray[0] = new Vector3(1, 1, 2));
        // Debug.Log(transform.position);
        GeneratePos();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = posArray[PickRandomIndex()];
            Debug.Log(PickRandomIndex());
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = Vector3.zero;
        }
    }

    private Vector3 GetRandomPos()
    {
        float posX = Mathf.Round((Random.Range(0f, 1f)) * 100f) / 10f;
        float posY = Mathf.Round((Random.Range(0f, 1f)) * 100f) / 10f;
        float posZ = Mathf.Round((Random.Range(0f, 1f)) * 100f) / 10f;

        Vector3 newPos = new Vector3(posX, posY, posZ);
        return newPos;
    }

    public void GeneratePos()
    {
        for (int i = 0; i < posArray.Length; i++)
        {
            posArray[i] = GetRandomPos();
        }
    }

    public int PickRandomIndex()
    {
        return Random.Range(0, posArray.Length);
    }
}
