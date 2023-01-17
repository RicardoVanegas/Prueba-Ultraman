using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Display : MonoBehaviour
{
    public Card card;

    public TMP_Text nameText,
                        HP,
                        ATK,
                        Cost;
    public Image attribute,
                    rarity,
                    faction;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.cardName;
        HP.text = card.hp.ToString();
        ATK.text = card.atk.ToString();
        Cost.text = card.cost.ToString();

        attribute.sprite = card.attribute;
        rarity.sprite = card.rarity;
        faction.sprite = card.faction;

    }

    
}
