using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipHealth : MonoBehaviour
{
    public int health = 30; //sbj to change
    //public GameObject deathEffect;

    public Text healthtext;

    void Update()
    {
        healthtext.text = health.ToString();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        healthtext.text = 0.ToString();
    }

    
}
