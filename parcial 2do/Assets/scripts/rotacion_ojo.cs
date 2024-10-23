using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class rotacion_ojo : MonoBehaviour
{
    public Transform player; // Asigna el transform del jugador en el inspector
    public float rotationSpeed = 5f; // Velocidad de rotaci�n
    public GameObject Player;

    void Update()
    {
        if (player != null && Player.GetComponent<datos_jugador>().invisible == false)
        {
            Vector3 direction = player.position - transform.position;// Calcula la direcci�n hacia el jugador
            /*direction.y = -2;*/ // Ignora la altura (para no rotar verticalmente)

            // Calcula la rotaci�n deseada
            Quaternion targetRotation = Quaternion.LookRotation(direction); //Genera una rotaci�n que mira en la direcci�n calculada.
            // Rota suavemente hacia la direcci�n del jugador
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        if (Player.GetComponent<datos_jugador>().invisible == true)
        {
            transform.rotation = Quaternion.identity;//rotacion 0 }
        }

    }
}
