using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanza_agua : MonoBehaviour
{
    public Transform bulletSpawnPoint;// posisicion de bala en el eje x,y,z
    public GameObject bulletPrefab;// forma fisica de la bala
    public float bulletSpeed = 10;//velocidad de bala
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fire")) {Destroy(other.gameObject);
            Debug.Log("fuego apagado");
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))//cuando aprete la tecla "espacio" dispara
        {
            if (Player.GetComponent<datos_jugador>().balas_agua >= 1)
            {
                disparar();
            }

            Player.GetComponent<datos_jugador>().balas_agua -= 1;
            
            recalcular_cargador();
        }
    }
    void disparar()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);/* se le asignan las propiedades a la bala
            como viene siendo su forfa fisica que es el bullet prefab, la posicion den el eje x,y,z(position) y la direccion(rotation)*/
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;/*se asigna un rigidbody a la bala para que tenga fisicas y velocidad,colicion*/
    }

    void recalcular_cargador()
    {
        if (Player.GetComponent<datos_jugador>().balas_agua <= 0)
        {
            Player.GetComponent<datos_jugador>().balas_agua = 0;
        }
    }

    
}
