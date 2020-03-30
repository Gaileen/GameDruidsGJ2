using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooter : MonoBehaviour
{
    public float fireDelay = 0.25f;
    float coolDownTimer = 0;

    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        coolDownTimer -= Time.deltaTime;
        if (Input.GetButton("Fire1") && coolDownTimer <= 0)
        {
            coolDownTimer = fireDelay;
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
