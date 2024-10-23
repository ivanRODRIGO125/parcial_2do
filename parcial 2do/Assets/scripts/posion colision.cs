using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class posioncolision : MonoBehaviour
{
    public GameObject Player;
    public bool invisible;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))// si la bala enemiga choica con el jugador
        {
            Player.GetComponent<datos_jugador>().posion_cantidad += 1;
            Destroy(gameObject);
        }
    }
    


        
        
            
}
