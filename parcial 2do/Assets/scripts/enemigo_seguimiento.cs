using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemgio_seguimiento : MonoBehaviour
{
    public Transform objetivo;
    public float speed;
    public bool enemigo_destruido;
    public GameObject Player;



    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (objetivo.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

    }
    private void OnCollisionEnter(Collision pared)
    {
        if (pared.gameObject.CompareTag("Wall"))
        { Destroy(gameObject);
            Player.GetComponent<datos_jugador>().enemigo_vencido = true; 
            }
    }
}
