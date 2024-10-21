using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class script_menu : MonoBehaviour
{



    public void empezar_nivel(string nivel)
    {
        SceneManager.LoadScene(nivel);
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("saliste del juego");
    }

}