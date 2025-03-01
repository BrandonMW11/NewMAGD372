using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderCoroutine : MonoBehaviour
{
    //Make a cylinder object move, wait a bit, then print to the console
    public Transform position1;
    public Transform position2;
    public float waitTime;

    void Start()
    {
        
    }

    IEnumerator MyCoroutine(float temp) 
    {
        yield return new WaitForSeconds(temp); //Temp return
    }
}
