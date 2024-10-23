using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trofeo_script : MonoBehaviour
{public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))// si la bala enemiga choica con el jugador
        {
            SceneManager.LoadScene(0);

        }
    }
   
    
        
    


    void Update()
    {
        

    }
}
