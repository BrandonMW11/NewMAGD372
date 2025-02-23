using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VPressed : MonoBehaviour
{
    public Text pointArea;
    public Text warningArea;
    public Shuffling shuffle;

    void Start()
    {
        ShowScore(0);
        CardEventManager manageCards = GetComponent<CardEventManager>();
        manageCards.OnVPressed += ShowScoreEvent;
    }

    private void ShowScore(int pCount)
    {
        pointArea.text = pCount.ToString();
    }

    private void ShowScoreEvent(object sender, CardEventManager.OnVPressedEventArgs e) 
    {
        if(e.isIncreasing) 
        {
            warningArea.text = "";
        }
        else 
        {
            if(e.pointCount < 0) 
            {
                e.pointCount = 0;
                warningArea.text = "Not enough points!";
            }
            else 
            {
                warningArea.text = "";
                shuffle.Shuffle();
            }
        }
        ShowScore(e.pointCount);
    }
}
