using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripttp6 : MonoBehaviour
{
    public GameObject Player;
    public Transform reference;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Player.transform.position = reference.position;
        Debug.Log("te tepeaste");
    }
    // Update is called once per frame
    void Update()
    {





    }
}
