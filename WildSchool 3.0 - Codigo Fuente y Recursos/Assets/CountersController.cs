using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountersController : MonoBehaviour {

    public Text timeCounter;
    [Range(0f, 60f)]//Define un rango para controlar el valor de abajo (aplicable para cualquier variable) mediante una barra...
    public float valueTimeCounter;
    public float extraTime;
    public int bloq=0;
    public int numScena;
    public GameObject TituloGanaste;
    public GameObject siguienteNivel;
    public GameObject contJuego;
    public GameObject panel;
    public GameObject jugador;
    public PlayerController pc;

	// Use this for initialization
	void Start () {
        numScena = SceneManager.GetActiveScene().buildIndex;
        TituloGanaste.SetActive(false);
        panel.SetActive(false);
        siguienteNivel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (bloq != 0)
        {
            if (valueTimeCounter > 0)
            {
                valueTimeCounter -= Time.deltaTime;
                timeCounter.text = "Time: " + valueTimeCounter.ToString("0");
            }
            if (valueTimeCounter <=0)
            {
                valueTimeCounter = 0;
                extraTime += Time.deltaTime;
                if (pc.status != 1)
                {//Ejecución para partida ganada...
                    TituloGanaste.SetActive(true);
                    siguienteNivel.SetActive(true);
                    panel.SetActive(true);
                    contJuego.SendMessage("desactivarTitulo");
                    jugador.SendMessage("actualizarEstadoAnimacion", "animFly");
                    SceneManager.LoadScene(numScena+1);
                }
                else if(pc.status ==1)
                {
                    //Ejecución para partida perdida...
                    SceneManager.LoadScene(numScena);
                }
            }
        }
            
	}
    void cambiarBloq()
    {
        bloq = 1;
    }
}
