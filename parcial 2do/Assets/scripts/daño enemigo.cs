using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class da�oenemigo : MonoBehaviour
{
    public float da�o;//da�o que recibira el pj cuando colicione con la bala
    public GameObject Player;// referencia para sustraer vida del jugador


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))// si la bala enemiga choica con el jugador
        {
            Destroy(gameObject);
            Player.GetComponent<datos_jugador>().vida_player -= da�o;//llama la script de datos jugador para restarle a la vida el valor de da�o

            

        }
    }
}