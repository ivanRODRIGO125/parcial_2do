using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class da�oenemigo : MonoBehaviour
{
    public float da�o;//da�o que recibira el pj cuando colicione con la bala
    public GameObject Player;// referencia para sustraer vida del jugador





    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            // si la bala enemiga choica con el jugador
           


            Player.GetComponent<datos_jugador>().vida_player -= da�o;
             
       

    }
   
    
}

   