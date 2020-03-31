using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// basic outline for mvt/health of all enemies. will probably have more scripts inheriting this to add special methods for particular enemies 
public class EnemyBehavior : MonoBehaviour
{
    public int health = 30;
    //public GameObject deathEffect; // some prefab for later
    public float speed = 1f;
    public float rotSpeed = 45f;
    private Transform target;
    public GameObject player;

    void Start()
    {
        target = player.GetComponent<Transform>();
    }

    void Update()
    {
        // follow Player
        if (target != null) // prevent MissingRef errs
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        // face Player
        if (target != null)
        {
            Vector3 dir = target.position - transform.position;
            dir.Normalize();
            float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
            Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
        }

        //INSERT: if player is certain distance away, start Shoot()
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
