using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{
    public static void CreateCubeObject()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public static void SetPostionToZero(GameObject obj)
    {
        obj.transform.position = Vector3.zero;
    }

    public static void ChangeObjColor(GameObject obj, Color color, bool randomColor = false)
    {
        if (randomColor == true)
        {
            color = new Color(Random.value, Random.value, Random.value);
        }
        obj.GetComponent<MeshRenderer>().material.color = color;
    }
}
