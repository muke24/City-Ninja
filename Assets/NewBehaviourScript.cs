using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject PoolPrefab;
    List<GameObject> PooledGameObjects;
    // List<GameObject> SpawnedGameObjects;

    public GameObject Spawn()
    {

        GameObject returnGO;

        if (PooledGameObjects.Count == 0)
        {
            returnGO = Instantiate(PoolPrefab);
        }
        else
        {
            returnGO = PooledGameObjects[0];
            PooledGameObjects.RemoveAt(0);
        }

        return returnGO;
    }

    public void DeSpawn(GameObject despawnObject)
    {
        PooledGameObjects.Add(despawnObject);

        despawnObject.SetActive(false);

        despawnObject.transform.SetParent(null);
    }
}
