using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    //public GameObject cubePrefab;

    //private int count = 0;
    ObjectPooler objectPooler;
    private int extraNum;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    void FixedUpdate()
    {
        /*Instantiate(cubePrefab, transform.position, Quaternion.identity);
        count++;
        Debug.Log(count);*/
        objectPooler.SpawnFromPool("Cube", transform.position, Quaternion.identity);
        extraNum = objectPooler.GetExtraNum();
        if (extraNum > 0) 
        {
            for (int i = 1;  i <= extraNum; i++) 
            {
                objectPooler.SpawnFromPool(("Cube" + i.ToString()), transform.position, Quaternion.identity);
            }
        }
    }
}
