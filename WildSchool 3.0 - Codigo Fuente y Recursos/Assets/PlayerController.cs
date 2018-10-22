using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Animator animacionJugador;
    public GameObject gameCanvas;
    public GameObject TituloGanaste;
    public GameObject contJuego;
    public GameObject panel;
    public int perder = 0;
    CountersController countersCont;
    public GameObject counters;
    public int bloq = 0;
    public int status;

    // Use this for initialization
    void Start () {
        animacionJugador = GetComponent<Animator>();
        countersCont = GetComponent<CountersController>();
        panel.SetActive(false);
        TituloGanaste.SetActive(false);
        status = 0;
    }
	
	// Update is called once per frame
	void Update () {
        bool estaJugando = gameCanvas.GetComponent<ControladorJuego>().gameState == ControladorJuego.GameState.Playing;
        if (estaJugando && Input.GetKeyDown("space")) {
            actualizarEstadoAnimacion("animPlayerJump");
        }
	}
    public void actualizarEstadoAnimacion(string estado = null){
        if(estado != null){
            animacionJugador.Play(estado);
        }
    }

    private void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.tag == "enemigo") {//Si el objeto con el que se ha detectado el choque es el enemigo (identificado mediante su tag)...
            animacionJugador.Play("animLose");//Entonces, se ejecuta la animación de "perdiste"...
            gameCanvas.GetComponent<ControladorJuego>().gameState = ControladorJuego.GameState.Ended;
            TituloGanaste.SetActive(true);
            TituloGanaste.GetComponent<Text>().text = "PERDISTE!";
            panel.SetActive(true);
            contJuego.SendMessage("desactivarTitulo");
            status = 1;
            counters.GetComponent<CountersController>().valueTimeCounter = 0;
        }
    }
}
