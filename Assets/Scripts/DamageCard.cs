using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCard : MonoBehaviour {

    public Card card;
    public GameObject target;
    public int damage;
    public GameController controller;
    public GameObject player;

    private void Start ()
    {

        player = GameObject.FindGameObjectWithTag ("Player");


    }

    public void Action ()
    {
        controller = GameObject.FindGameObjectWithTag ("Controller").GetComponent<GameController> ();
        controller.targeted.gameObject.transform.parent.GetComponent<EnemyScript> ().TakeDamage (controller.selected.gameObject.transform.parent.GetComponent<CardDisplay> ().card.healthChange);
        //Debug.Log (controller.selected.gameObject.transform.parent.GetComponent<CardDisplay> ().card.healthChange);
        

    }

}
