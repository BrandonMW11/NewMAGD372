using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ObjectPooler;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool 
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public static ObjectPooler Instance;

    private void Awake()
    {
        Instance = this;
    }

    public List<Pool> pools;
    public List<Pool> extras;
    public int max;
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    private int extraCount = 0;

    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in pools) 
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for (int i = 0; i < pool.size; i++) 
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            poolDictionary.Add(pool.tag, objectPool);
        }
        Debug.Log(poolDictionary.Count);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (poolDictionary.Count < max)
            {
                AddMore();
            }
            Debug.Log(poolDictionary.Count);
        }
    }

    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation) 
    {
        if (!poolDictionary.ContainsKey(tag)) 
        {
            Debug.LogWarning("Pool with tag " + tag + " doesn't exist");
            return null;
        }

        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        IPooledObject pooledObj = objectToSpawn.GetComponent<IPooledObject>();

        if (pooledObj != null) 
        {
            pooledObj.OnObjectSpawn();
        }

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }

    public void AddMore() 
    {
        foreach (Pool pool in extras)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            extraCount++;
            string newName = pool.tag + extraCount.ToString();
            poolDictionary.Add(newName, objectPool);
        }
    }

    public int GetExtraNum() 
    {
        return extraCount;
    }
}
