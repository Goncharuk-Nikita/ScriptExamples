using UnityEngine;
using System;
using System.Collections.Generic;

[Serializable]
public class Prefab
{
    public GameObject prefab;
    public int count;
    public Transform parent;
    
    
    public List<PoolablePrefabData> Install()
    {
        return PrefabPoolingSystem.Prespawn(prefab, count, parent);
    }


    public PoolablePrefabData Spawn()
    {
        return Spawn(Vector2.zero, Quaternion.identity);
    }

    public PoolablePrefabData Spawn(Vector2 position)
    {
        return Spawn(position, Quaternion.identity);
    }

    public PoolablePrefabData Spawn(Vector2 position, Quaternion rotation)
    {
        return PrefabPoolingSystem.Spawn(prefab, position, rotation);
    }    
}
