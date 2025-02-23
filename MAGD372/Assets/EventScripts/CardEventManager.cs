using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static EventManager;

public class CardEventManager : MonoBehaviour
{
    public EventHandler<OnVPressedEventArgs> OnVPressed;
    public class OnVPressedEventArgs : EventArgs
    {
        public int pointCount;
        public bool isIncreasing;
    }

    private int pointCount = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (OnVPressed != null)
            {
                pointCount++;
                OnVPressed(this, new OnVPressedEventArgs { pointCount = pointCount, isIncreasing = true });
            }
        }
        if (Input.GetKeyDown(KeyCode.C)) 
        {
            if (OnVPressed != null) 
            {
                pointCount--;
                OnVPressed(this, new OnVPressedEventArgs { pointCount = pointCount, isIncreasing = false });
                if(pointCount < 0) 
                {
                    pointCount = 0;
                }
            }
        }
    }
}
