using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class torreta_rotacion : MonoBehaviour
{
    public Transform player; // Asigna el transform del jugador en el inspector
    public float rotationSpeed = 5f; // Velocidad de rotación

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;// Calcula la dirección hacia el jugador
            /*direction.y = -2;*/ // Ignora la altura (para no rotar verticalmente)

            // Calcula la rotación deseada
            Quaternion targetRotation = Quaternion.LookRotation(direction); //Genera una rotación que mira en la dirección calculada.
            // Rota suavemente hacia la dirección del jugador
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

}