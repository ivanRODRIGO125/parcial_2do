using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class datos_jugador : MonoBehaviour
{

    public float vida_player;
    public float vida_muerte = 0;
    string BALASstring;
    public float balas;
    public Text bullets;
    public Text vida;
    public Text posion;
    public Text invisibilidad;
    public string life;
    public string posion_string;
    public float posion_cantidad;
    public bool invisible;
    


    private void Update()
    {
        posion_string = $"{posion_cantidad}";
        posion.text = posion_string;

        life = $"{vida_player}";// con un string hago que la vida numerica se reconozca como string
        vida.text = life;//vinculo el texto a la vida reconocida como string

        if (vida_player <= 0)// si vida jugador es 0
        {
            Debug.Log("game over");// en consola dice game over

            Destroy(gameObject);// jugador se destruye
            ReloadScene();//funcion con codigo para reiniciar escena
        }
        void ReloadScene()
        {
            SceneManager.LoadScene(1);
        }

        BALASstring = $"{balas}";

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
    }
    void avisar_invisibilidad()
    { if (invisible == true) { } }
}



