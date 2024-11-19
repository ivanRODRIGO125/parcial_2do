using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp_false : MonoBehaviour
{
    public GameObject Player;
    public Transform reference;
    public int daño;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Player.transform.position = reference.position;
        Debug.Log("te tepeaste");
        Player.GetComponent<datos_jugador>().vida_player -= daño;
    }
    // Update is called once per frame
    void Update()
    {





    }
}
