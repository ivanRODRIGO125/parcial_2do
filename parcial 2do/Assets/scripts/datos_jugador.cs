using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class datos_jugador : MonoBehaviour
{
    public float vida_player;
    public Slider vidaVisual;
    public float vida_muerte = 0;

    private void Update()
    {

        /*vidaVisual.GetComponent<Slider>().value = vida_player;*///toma de referencia el valor de Slider para la vidavisual y hace que ese valor sea vidaplayer

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
    }
}
