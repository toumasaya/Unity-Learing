using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // 1. Create a list/array to random spawan 3 GameObject
    // 2. Spawn random Gameobject and poistion -10 or +10 on the x/y when enter Space key
    // 3. Eyery spwaned objects should be stored into a list called objectCreated
    // 4. When spawned 10 objects, no longer be able to spawn and turn all objects to Color green
    // and then clear  objectCreated list
    public GameObject[] SpawnArray = new GameObject[3];
    public List<GameObject> objectCreated = new List<GameObject>();
    public int SpawnCount { get; set; }
    private bool _initChangeColor;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SpawnCount == 10)
            {
                _initChangeColor = true;
                return;
            }

            GameObject objectToSpawn = SpawnArray[Random.Range(0, SpawnArray.Length)];
            int randomX = Random.Range(-10, 10);
            int randomY = Random.Range(-10, 10);
            var pos = new Vector3(randomX, randomY, 0);
            // GameObject go = Instantiate(objectToSpawn, pos, Quaternion.identity);
            var go = Instantiate(objectToSpawn, pos, Quaternion.identity) as GameObject;

            objectCreated.Add(go);
            SpawnCount++;
        }

        if (_initChangeColor == true)
        {
            _initChangeColor = false;
            foreach (var obj in objectCreated)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }

            StartCoroutine(ClearSpawnedObjects());
            DeleteAllObjects();
        }
    }

    IEnumerator ClearSpawnedObjects()
    {
        yield return new WaitForSeconds(1);
        objectCreated.Clear();
    }

    void DeleteAllObjects()
    {
        var objects = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var obj in objects)
        {
            Destroy(obj, 2);
        }
    }
}
