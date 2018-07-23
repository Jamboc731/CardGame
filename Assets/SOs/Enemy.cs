using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy", order = 1)]
public class Enemy : ScriptableObject {

    public new string name;
    public int numberOfMoves;
    public int damage;
    public int health;
    public Sprite art;

    public void Action ()
    {



    }

}
