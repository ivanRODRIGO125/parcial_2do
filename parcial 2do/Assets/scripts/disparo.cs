using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public Transform bulletSpawnPoint;// posisicion de bala en el eje x,y,z
    public GameObject bulletPrefab;// forma fisica de la bala
    public float bulletSpeed = 10;//velocidad de bala
    


    void Update()
    {
        if (Input.GetButtonDown("Fire1") )//cuando aprete la tecla "espacio" dispara
        {
            disparar();
           
        }
    }
    void disparar() {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);/* se le asignan las propiedades a la bala
            como viene siendo su forfa fisica que es el bullet prefab, la posicion den el eje x,y,z(position) y la direccion(rotation)*/
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;/*se asigna un rigidbody a la bala para que tenga fisicas y velocidad,colicion*/ }
        
    
    private void OnTriggerEnter(Collider other)//si pj coliciona con bala enemiga, la bala se destruye
        {
            if (other.CompareTag("balaenemiga"))
            {
                Destroy(other.gameObject);



            }
        }
    } 
