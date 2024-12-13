using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balagigantedaño : MonoBehaviour
{public GameObject Player;
    public Transform checkpoint;
    public float daño;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) { Player.GetComponent<datos_jugador>().Player_transform.position = checkpoint.position;
            Player.GetComponent<datos_jugador>().vida_player -= daño;
        }
    }
}
