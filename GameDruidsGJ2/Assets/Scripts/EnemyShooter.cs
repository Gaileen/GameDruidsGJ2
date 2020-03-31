using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public Transform player;

    public float playerInRange = 3f;

    public float fireDelay = 1f;
    float coolDownTimer = 0;

    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        coolDownTimer -= Time.deltaTime;
        if (coolDownTimer <= 0)
        {
            coolDownTimer = fireDelay;
            if (player != null)
            {
                float dist = Vector3.Distance(player.position, transform.position);

                // if player in x distance, start shooting
                if (dist <= playerInRange)
                {
                    Shoot();
                }
            }
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
