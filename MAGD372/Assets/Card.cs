using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Card : ScriptableObject
{
    public string cardName;
    public string description;
    public Sprite art;
    public bool hasRandomRarity;
    public int rarity;
}
