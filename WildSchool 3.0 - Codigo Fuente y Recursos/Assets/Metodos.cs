using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Metodos : MonoBehaviour {

    public int numScena;

    // Use this for initialization
    void Start(){
        numScena = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update(){ 
    
    }

        public void iniciarJuegoButton()
    {//Si presionan el botón "Iniciar Juego"...
        SceneManager.LoadScene(numScena + 1);//Se inicia la siguiente escena...
    }

    public void salirJuegoButton()
    {//Si presionan el botón "Salir"...
        Application.Quit();//El juego se cierra...
    }
}
