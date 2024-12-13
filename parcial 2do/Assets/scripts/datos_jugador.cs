using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using System;


public class datos_jugador : MonoBehaviour
{

    public float vida_player;
    public float vida_muerte = 0;
    string BALASstring;
    public float balas;
    public Text bullets;
    public Text vida;
    public Text posion;
    public Text agua;
    public string life;
    public string posion_string;
    public float posion_cantidad;
    public bool invisible;
    public float ylimit = 160;
    public bool enemigo_vencido;
    public Transform Player_transform;
    public bool quemandose=false;
    public float balas_agua;
    string agua_string;
    



    
        private void Update()
    {
        















        agua_string = $"water:{balas_agua}";
        agua.text = agua_string;
        caida_mapa();

        posion_string = $"pill:{posion_cantidad}";
        posion.text = posion_string;

        life = "health:" + MathF.Round(vida_player);// con un string hago que la vida numerica se reconozca como string
        vida.text = life;//vinculo el texto a la vida reconocida como string

        if (vida_player <= 0)// si vida jugador es 0
        {
            Debug.Log("game over");// en consola dice game over

           /* Destroy(gameObject);*/// jugador se destruye
            ReloadScene();//funcion con codigo para reiniciar escena
        }
        void ReloadScene()
        {
            SceneManager.LoadScene(1);
        }

        BALASstring = $"AMMO:{balas}";

        bullets.text = BALASstring;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (posion_cantidad >= 1)
            {
                tomar();
                invisible = true;
            }



        }

        void tomar() { posion_cantidad -= 1; }

        if (vida_player >= 100)
        {
            vida_player = 100;
        }
        
        
    }
    void avisar_invisibilidad()
    { if (invisible == true) { } }

    //private void OnTriggerEnter(Collider other)
    //{if (other.CompareTag("pildora"))
    //    { pildoraTEXT.GetComponent<pildora_text_script>().tiempo_de_vida += 4;
    //        Destroy(other.gameObject);
    //    }
        
    //}

    void caida_mapa()
    {
        if (this.transform.position.y < ylimit)
            {
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }
    }

    
}



