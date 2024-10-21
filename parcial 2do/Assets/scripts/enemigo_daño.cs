using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaENEMIGA : MonoBehaviour
{
    public float daño;//daño que recibira el pj cuando colicione con la bala
    public GameObject Player;// referencia para sustraer vida del jugador


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))// si la bala enemiga choica con el jugador
        {
            Player.GetComponent<datos_jugador>().vida_player -= daño;
            /*Destroy(other.gameObject);*/// jugador se destruye

        }
    }
}
