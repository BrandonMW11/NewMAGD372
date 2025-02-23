using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{
    public delegate void TestDelegate();
    public delegate bool TestBoolDelegate(int i);

    private TestDelegate testDelegateFunction;

    void Start()
    {
        testDelegateFunction = delegate () { Debug.Log("I'm getting tired"); };
        /*testDelegateFunction = MyTestDelegate;
        testDelegateFunction += MyTestDelegate2;
        Debug.Log(MyBoolTest(3));*/
        testDelegateFunction();
        //Debug.Log(MyBoolTest(6));
    }

    private void MyTestDelegate() 
    {
        Debug.Log("The wind blows");
    }

    private void MyTestDelegate2() 
    {
        Debug.Log("hard in December");
    }

    private bool MyBoolTest(int i) 
    {
        return i < 5;
    }
}
