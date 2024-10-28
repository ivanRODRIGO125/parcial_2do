using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cambiar_color : MonoBehaviour
{
    public GameObject brazo;
    public GameObject Player;
    public Material material;
    void color_change()
    {

        if (Player.GetComponent<datos_jugador>().invisible == true)
        {
            material.color = Color.red;



        }
        else
        {
            material.color = Color.yellow;

        }
    }

        // Update is called once per frame
        void Update()
        {
            color_change();

        }
    
}
