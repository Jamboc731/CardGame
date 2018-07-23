using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {
    
    public Image selected;
    public GameController controller;
    public Color selectedColour = new Color (255, 255, 0, 255);
    public Color unselectedColour = new Color (0, 0, 0, 0);
    public Color targetedColour = new Color (255, 0, 0, 255);

    private void Start ()
    {

        controller = GameObject.FindGameObjectWithTag ("Controller").GetComponent<GameController> ();

    }

    public void CardClick ()
    {
        
        controller.selected.color = unselectedColour;
        controller.selected = selected;
        controller.selected.color = selectedColour;
        controller.actionEffect = selected.transform.parent.gameObject.GetComponent<CardDisplay> ().card.type.GetComponent<DamageCard> ();

    }

    public void EnemyClick ()
    {

        controller.targeted.color = unselectedColour;
        controller.targeted = selected;
        controller.targeted.color = targetedColour;
        
    }

    public void ActionButton ()
    {

        controller.actionEffect.Action ();

    }

}
