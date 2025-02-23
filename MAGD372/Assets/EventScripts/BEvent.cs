using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEvent : MonoBehaviour
{
    void Start()
    {
        EventManager manageEvent = GetComponent<EventManager>();
        manageEvent.OnBPressed += TestingBPressed;
        manageEvent.OnFloatEvent += TestingOnFloat;
        manageEvent.OnActionEvent += TestingActionEvent;
    }

    private void TestingActionEvent(bool arg1, int arg2) 
    {
        Debug.Log(arg1 + " " + arg2);
    }

    private void TestingOnFloat(float f)
    {
        Debug.Log("Float " + f);
    }

    private void TestingBPressed(object sender, EventManager.OnBPressedEventArgs e)
    {
        Debug.Log("B " + e.bCount);
        //EventManager manageEvent = GetComponent<EventManager>();
        //manageEvent.OnBPressed -= TestingBPressed;
    }

    void Update()
    {
        
    }
}
