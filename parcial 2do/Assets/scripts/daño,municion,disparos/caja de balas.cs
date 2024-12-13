using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class powrup : MonoBehaviour
{
    
    public float balas_agregadas;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bulletbox"))//si pj coliciona con otro objeto(busca el tag de ese otro objeto para identificar)

        {
            Player.GetComponent<datos_jugador>().balas += balas_agregadas;

            Destroy(other.gameObject);
            Debug.Log(Player.GetComponent<datos_jugador>().balas);
            
        }

    }
}