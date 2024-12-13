using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dañoenemigo : MonoBehaviour
{
    public float daño;//daño que recibira el pj cuando colicione con la bala
    public GameObject Player;// referencia para sustraer vida del jugador





    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            // si la bala enemiga choica con el jugador
           


            Player.GetComponent<datos_jugador>().vida_player -= daño;
             
       

    }
   
    
}

   