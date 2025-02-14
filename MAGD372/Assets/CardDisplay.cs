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

    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        rarityText.text = card.rarity.ToString();
        artImage.sprite = card.art;
    }
}
