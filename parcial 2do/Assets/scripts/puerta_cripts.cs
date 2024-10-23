using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta_cripts : MonoBehaviour
{public GameObject Player;
    

    
    void Update()
    {
        if (Player.GetComponent<datos_jugador>().invisible == true) { Destroy(gameObject); }
        
    }
}
