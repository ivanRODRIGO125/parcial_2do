using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class rotacion_ojo : MonoBehaviour
{
    public Transform player; // Asigna el transform del jugador en el inspector
    public float rotationSpeed = 5f; // Velocidad de rotación
    public GameObject Player;

    void Update()
    {
        if (player != null && Player.GetComponent<datos_jugador>().invisible == false)
        {
            Vector3 direction = player.position - transform.position;// Calcula la dirección hacia el jugador
            /*direction.y = -2;*/ // Ignora la altura (para no rotar verticalmente)

            // Calcula la rotación deseada
            Quaternion targetRotation = Quaternion.LookRotation(direction); //Genera una rotación que mira en la dirección calculada.
            // Rota suavemente hacia la dirección del jugador
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        if (Player.GetComponent<datos_jugador>().invisible == true)
        {
            transform.rotation = Quaternion.identity;//rotacion 0 }
        }

    }
}
