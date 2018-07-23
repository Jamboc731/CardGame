using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

    public Image cardTemplate;
    public Text name;
    public Text description;
    public Card card;
    public Text cost;
    public Image art;

    private void Start ()
    {

        name.text = card.name;
        description.text = card.description;
        cost.text = card.cost.ToString();
        art.sprite = card.art;
        
    }

}
