using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehavior : MonoBehaviour
{
    public float screenHeight = 5f;

    public int health = 30;
    //public GameObject deathEffect; // some prefab for later

    void Start()
    {
        transform.Rotate(0, 0, Random.value * 360);
        GetComponent<Rigidbody2D>().AddForce(transform.up * (Random.value * 50f));
    }

    void Update()
    {
        transform.position = AsteroidMath.Wrap(transform.position, screenHeight);
    }

    // if Player collides, then Player dies from crash
    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.CompareTag("Player"))
        {
            //Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(otherObj.gameObject);
        }
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
    }
}
