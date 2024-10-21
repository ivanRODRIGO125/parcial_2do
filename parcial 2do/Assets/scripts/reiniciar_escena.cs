using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reinicio_escena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))//si se apreta la tecla R
        {
            ReloadScene();// reinicia escena
        }
        void ReloadScene()
        {
            
            SceneManager.LoadScene(1);
        }

    }

}