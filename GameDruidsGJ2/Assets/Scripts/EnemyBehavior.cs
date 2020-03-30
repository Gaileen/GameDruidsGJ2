using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// basic outline for all enemies. will probably have more scripts inheriting this to add special methods for particular enemies 
public class EnemyBehavior : MonoBehaviour
{
    public int health = 30;
    //public GameObject deathEffect; // some prefab for later
    public float speed = 1f;
    private Transform target;
    public GameObject player;

    void Start()
    {
        target = player.GetComponent<Transform>();
       // target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        // follow Player (when seen?)
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
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
