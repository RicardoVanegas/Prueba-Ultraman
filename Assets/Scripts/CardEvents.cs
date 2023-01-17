using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardEvents : MonoBehaviour
{

    public Card card;
    public GameObject panelName;
    public TMP_Text cardName;
    public TMP_Text rarity;

    public GameObject panelAttribute;
    public TMP_Text attribute;


    public TMP_Text hp,
                    cost,
                    ATK;
    public GameObject panelHP;

    
    public AudioSource wav;
  
    

    // Start is called before the first frame update
    void Start()
    {
        cardName.text = card.cardName;
        rarity.text = card.rarityText;
        attribute.text = card.attributeText;
        hp.text = card.hp.ToString();
        cost.text = card.cost.ToString();
        ATK.text = card.atk.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Input.mousePosition.x >= 117 && Input.mousePosition.x <= 408 && Input.mousePosition.y >= 64 && Input.mousePosition.y <= 514)
        {
            panelName.SetActive(true);
            wav.Play();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && Input.mousePosition.x >= 117 && Input.mousePosition.x <= 408 && Input.mousePosition.y >= 64 && Input.mousePosition.y <= 514)
        {
            panelHP.SetActive(true);
            wav.Play();
        }
       
        
    }
}
