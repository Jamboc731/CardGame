using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour {

    public Enemy enemy;
    public Text name;
    public Image art;
    public float health;
    public int damage;
    public int numerOfMoves;
    public Image healthBar;
    public Image selected;
    public GameController controller;
    public float maxHealth;

    private void Start ()
    {

        controller = GameObject.FindGameObjectWithTag ("Controller").GetComponent<GameController> ();
        name.text = enemy.name;
        art.sprite = enemy.art;
        health = enemy.health;
        numerOfMoves = enemy.numberOfMoves;
        damage = enemy.damage;
        maxHealth = health;
        
    }

    public void TakeDamage (int damage)
    {

        health = health - damage;
        healthBar.fillAmount = health / maxHealth;
        if(health <= 0)
        {

            controller.targeted = GameObject.Find ("DNUTarget").GetComponent<Image>();
            Destroy (gameObject);

        }

    }



}
