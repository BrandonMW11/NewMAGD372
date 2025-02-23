using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public EventHandler<OnBPressedEventArgs> OnBPressed;
    public class OnBPressedEventArgs : EventArgs
    {
        public int bCount;
    }

    public event TestEventDelegate OnFloatEvent;
    public delegate void TestEventDelegate(float f);

    public event Action<bool, int> OnActionEvent;

    private int bCount;

    private void Start()
    {
        //OnBPressed += TestingBPressed;
    }

    /*private void TestingBPressed(object sender, EventArgs e) 
    {
        Debug.Log("B");
    }*/

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)) 
        {
            bCount++;
            if (OnBPressed != null)
            {
                OnBPressed(this, new OnBPressedEventArgs {bCount = bCount});
            }
            if (OnFloatEvent != null)
            {
                OnFloatEvent(1.5f);
            }
            if (OnActionEvent != null)
            {
                OnActionEvent(true, 11);
            }
        }
    }
}
