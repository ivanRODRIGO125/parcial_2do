using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsula_vida_script : MonoBehaviour
{
    public GameObject Player;
    public float curar;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))// si la bala enemiga choica con el jugador
        {
            Destroy(gameObject);
            Player.GetComponent<datos_jugador>().vida_player += curar;//llama la script de datos jugador para restarle a la vida el valor de daño



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
