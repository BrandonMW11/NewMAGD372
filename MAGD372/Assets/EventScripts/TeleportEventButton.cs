using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEventButton : MonoBehaviour
{
    public GameObject destination;
    public PlayerMovement movement;

    void OnEnable()
    {
        EventManager2.OnClicked += Teleport;
    }

    void OnDisable()
    {
        EventManager2.OnClicked -= Teleport;
    }

    void Teleport() //Can't work on player becuase of Movement's update
    {
        if (movement != null) 
        {
            movement.DisableMovement();
        }

        Vector3 pos = destination.transform.position;
        transform.position = pos;

        /*if (movement != null)
        {
            movement.EnableMovement();
        }

        Vector3 playerPos = transform.position;
        playerPos.y = Random.Range(10, 50);
        transform.position = playerPos;*/
    }
}
