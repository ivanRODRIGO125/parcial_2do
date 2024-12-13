using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo_torreta : MonoBehaviour
{
    public Transform bulletSpawnPoint;// posisicion de bala en el eje x,y,z
    public GameObject bulletPrefab;// forma fisica de la bala
    public float bulletSpeed = 10;//velocidad de bala
    public GameObject Player;
    public float fireRate = 1f; // Disparos por segundo

    private float nextFireTime = 1f;

    void Update()
    {
        // Verifica si es posible disparar
        if (Time.time >= nextFireTime)
        {
            Fire();
            nextFireTime = Time.time + 1f / fireRate; // Calcula el tiempo del próximo disparo
        }
    }

    void Fire()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);/* se le asignan las propiedades a la bala
            como viene siendo su forfa fisica que es el bullet prefab, la posicion den el eje x,y,z(position) y la direccion(rotation)*/
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;/*se asigna un rigidbody a la bala para que tenga fisicas y velocidad,colicion*/
    }

}




