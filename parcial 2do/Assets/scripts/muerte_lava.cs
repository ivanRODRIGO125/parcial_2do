using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerte_lava : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            { Player.GetComponent<datos_jugador>().vida_player = 0; }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
