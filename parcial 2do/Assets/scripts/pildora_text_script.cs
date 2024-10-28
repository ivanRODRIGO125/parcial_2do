using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pildora_text_script : MonoBehaviour
{
    public float tiempo_de_vida = 0;
    public GameObject texto_pildora;

    // Update is called once per frame
    void Update()
    {
        tiempo_de_vida -= Time.deltaTime;

        if (tiempo_de_vida <= 0)
        {
            Destroy(texto_pildora);

        }

        if (tiempo_de_vida >= 1)
        {
            mostrar_texto();

        }
    }
    public void mostrar_texto() 
    { GameObject texto = Instantiate(texto_pildora); }
}
