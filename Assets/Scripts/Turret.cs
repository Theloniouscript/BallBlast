using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float projectileInterval;


    [SerializeField] private int damage;
    public int Damage => damage;


    [SerializeField] private float fireRate;
    public float FireRate => fireRate;


    [SerializeField] private int projectileAmount;
    public int ProjectileAmount => projectileAmount;

    

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
    }

    public void Fire()
    {
        if(timer >= fireRate)
        {
            SpawnProjectile();
            timer = 0;
        }
    }

    private void SpawnProjectile()
    {
        float startPosX = shootPoint.position.x - projectileInterval * (projectileAmount - 1) * 0.5f;
        for (int i = 0; i < projectileAmount; i++)
        {
            Projectile projectile = Instantiate(projectilePrefab, 
                        new Vector3(startPosX + i * projectileInterval, shootPoint.position.y, shootPoint.position.z), 
                        transform.rotation);

            projectile.SetDamage(damage);
        }


        //Instantiate(projectilePrefab, shootPoint.position, transform.rotation);
    }
}
