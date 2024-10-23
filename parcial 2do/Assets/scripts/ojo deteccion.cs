using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ojodeteccion : MonoBehaviour
{public GameObject prefab_bala;
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))// si la bala enemiga choica con el jugador
        {
            
            Destroy(gameObject);
            Destroy(door);

        }
    }
}
