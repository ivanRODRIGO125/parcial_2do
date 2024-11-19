using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class fuego_daño : MonoBehaviour
{
    public GameObject Player;
    public float daño;
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player")) 
        { Player.GetComponent<datos_jugador>().quemandose= true; }
        
    }
    private void OnTriggerExit(Collider other)
    {
     if (other.CompareTag("Player")) { Player.GetComponent<datos_jugador>().quemandose = false; }


    }
    void Update()
    {
        int numeroEntero = (int)Math.Round(daño);
        if (Player.GetComponent<datos_jugador>().quemandose == true) 
        {Player.GetComponent<datos_jugador>().vida_player -= daño; }
        


    }
}
