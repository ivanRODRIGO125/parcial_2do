using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class piso_destruccion : MonoBehaviour
{
    
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {if (Player.GetComponent<datos_jugador>().enemigo_vencido == true) {Destroy(gameObject); }
        
    }
}
