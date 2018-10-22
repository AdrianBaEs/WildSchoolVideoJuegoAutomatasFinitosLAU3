using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OutroController : MonoBehaviour {

    // Use this for initialization
    void Start(){
    }

    // Update is called once per frame
    void Update(){

    }

    public void reiniciarJuegoButton(){//Si presionan el botón "Iniciar Juego"...
        SceneManager.LoadScene(1);//Se inicia la siguiente escena...
    }

    public void salirJuegoButton(){//Si presionan el botón "Salir"...
        Application.Quit();//El juego se cierra...
    }
}
