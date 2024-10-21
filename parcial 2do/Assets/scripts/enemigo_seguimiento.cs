using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemgio_seguimiento : MonoBehaviour
{
    public Transform objetivo;
    public float speed;



    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (objetivo.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}
