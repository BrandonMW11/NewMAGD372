using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffling : MonoBehaviour
{
    public Card[] cardOptions;
    public CardDisplay[] cardDisplays;

    private int rand;
    private int[] blacklist = {999, 999, 999};
    private bool valid = false;

    void Start()
    {
        Shuffle();
    }

    public void Shuffle() 
    {
        for(int i = 0; i < blacklist.Length; i++) 
        {
            blacklist[i] = 999;
        }

        for(int i = 0; i < cardDisplays.Length; i++) 
        {
            rand = Random.Range(0, cardOptions.Length);
            valid = false;
            while (!valid) 
            {
                rand = Random.Range(0, cardOptions.Length);
                for(int j = 0; j < blacklist.Length; j++) 
                {
                    if(rand == blacklist[j]) 
                    {
                        valid = false;
                        break;
                    }
                    else 
                    {
                        valid = true;
                    }
                }
            }
            blacklist[i] = rand;
            cardDisplays[i].card = cardOptions[rand];
            cardDisplays[i].DisplayCard();
        }
    }
}
