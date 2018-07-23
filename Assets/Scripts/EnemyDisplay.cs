using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDisplay : MonoBehaviour {

    public string name;
    public int health;
    public Sprite art;
    public Enemy enemy;

    private void Start ()
    {

        name = enemy.name;
        health = enemy.health;
        art = enemy.art;

    }

}
