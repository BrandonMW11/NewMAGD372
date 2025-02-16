using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text nameText;
    public Text descriptionText;
    public Text rarityText;
    public Image artImage;

    private int rand;
    private bool randomStatus;

    void Start()
    {
        DisplayCard();
    }

    public void DisplayCard() 
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        randomStatus = card.hasRandomRarity;
        artImage.sprite = card.art;

        if (randomStatus)
        {
            rand = Random.Range(1, 6);
            rarityText.text = rand.ToString();
        }
        else
        {
            rarityText.text = card.rarity.ToString();
        }
    }
}
