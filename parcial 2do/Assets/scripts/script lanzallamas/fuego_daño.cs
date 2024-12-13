using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class fuego_daño : MonoBehaviour
{
    public GameObject Player;
    public float daño;
    public Image bloodImage;
    public float r;
    public float g;
    public float b;
    public float a;

    void Start()
    {
        r = bloodImage.color.r;
        g = bloodImage.color.g;
        b = bloodImage.color.b;
        a = bloodImage.color.a;

    }






    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        { Player.GetComponent<datos_jugador>().quemandose = true; }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) { Player.GetComponent<datos_jugador>().quemandose = false; }


    }
    void Update()
    {
        int numeroEntero = (int)Math.Round(daño);
        if (Player.GetComponent<datos_jugador>().quemandose == true)
        { Player.GetComponent<datos_jugador>().vida_player -= daño;
            a += 0.01f;

            a -= 0.001f;
            a = Mathf.Clamp(a, 0, 1f);

            changecolor();
        }
        if (Player.GetComponent<datos_jugador>().quemandose == false)
        {
            a -= 0.001f;

            a = Mathf.Clamp(a, 0, 1f);

            changecolor();

        }
        
    }
    private void changecolor()
    {
        Color c = new Color(r, g, b, a);
        bloodImage.color = c;
    }
}

