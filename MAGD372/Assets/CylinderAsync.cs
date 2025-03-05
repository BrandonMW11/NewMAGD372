using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CylinderAsync : MonoBehaviour
{
    public Transform position1;
    public Transform position2;

    /*void Start()
    {
        MyAsync();
    }*/

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            MyAsync();
        }
    }

    public async void MyAsync()
    {
        transform.position = position1.position;
        while (transform.position.x > position2.position.x)
        {
            Vector3 pos = transform.position;
            pos.x -= .1f;
            transform.position = pos;
            await Task.Yield();
        }
        //yield return new WaitForSeconds(1.5f);
        Debug.Log("Async done");
        await Task.Yield();
    }
}
