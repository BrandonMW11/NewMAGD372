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

    void Teleport()
    {
        if (movement != null) 
        {
            movement.DisableMovement();
        }

        Vector3 pos = destination.transform.position;
        transform.position = pos;
    }
}
