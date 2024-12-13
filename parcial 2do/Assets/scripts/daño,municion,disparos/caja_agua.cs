using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja_agua : MonoBehaviour
{
    public float agua_agregada;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("waterbox"))//si pj coliciona con otro objeto(busca el tag de ese otro objeto para identificar)

        {
            Player.GetComponent<datos_jugador>().balas_agua += agua_agregada;

            Destroy(other.gameObject);
            

        }

    }
}

