using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderCoroutine : MonoBehaviour
{
    //Make a cylinder object move, wait a bit, then print to the console
    public Transform position1;
    public Transform position2;

    void Start()
    {
        StartCoroutine(MyCoroutine()); 
    }

    IEnumerator MyCoroutine() 
    {
        while (transform.position.x > position2.position.x) 
        {
            Vector3 pos = transform.position;
            pos.x -= .1f;
            transform.position = pos;
            yield return null;
        }
        Debug.Log("Coroutine done");
        yield return new WaitForSeconds(1.5f); //Makes this act like void
    }
}
