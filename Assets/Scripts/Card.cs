using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName ="new card", menuName = "card")]
public class Card : ScriptableObject
{
    public string cardName;

    public Sprite faction;
    public string factionText;
    public Sprite attribute;
    public string attributeText;
    public Sprite rarity;
    public string rarityText;

    public int id,
                cost,
                atk,
                hp;
}
