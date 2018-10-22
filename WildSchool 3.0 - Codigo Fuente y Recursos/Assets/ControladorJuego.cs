﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControladorJuego : MonoBehaviour {
    [Range(0.02f, 0.40f)]//Define un rango para controlar el valor de abajo (aplicable para cualquier variable) mediante una barra...
    public float velocidadParallax = 0.02f;
    public RawImage wildSchool_Background, wildSchool_Foreground, wildSchool_Platform;

    //Estados del juego (inicio y jugando)...
    public enum GameState { Idle, Playing, Ended };
    public GameState gameState = GameState.Idle;//Con esta declaración, se define que el estado por default del juego es inicio o detenido...

    public GameObject tituloNivel;//Objeto que controla el titulo de la pantalla...
    public GameObject subtituloNivel;//Objeto que controla el subtitulo de la pantalla...
    public GameObject jugador;
    public GameObject timer;

    // Use this for initialization
    void Start()
    {
        tituloNivel.SetActive(false);//Inicialmente, la palabra "GO!" no será mostrada...
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState == GameState.Idle && (Input.GetKeyDown("space")))
        {//En caso de presionar la flecha "arriba" o el lado izquierdo del mouse...
            //Se inicia el juego...
            gameState = GameState.Playing;
            subtituloNivel.SetActive(false);
            tituloNivel.SetActive(true);
            jugador.SendMessage("actualizarEstadoAnimacion", "animPlayerRun");
            timer.SendMessage("cambiarBloq");
        }
        else if (gameState == GameState.Playing)
        {
            efectoParallax();
        }
        else if (gameState == GameState.Ended)
        {
            //Mostrar GameOver y opciones...
        }
    }
    void efectoParallax()
    {
        float finalSpeed = velocidadParallax * Time.deltaTime;
        wildSchool_Background.uvRect = new Rect(wildSchool_Background.uvRect.x + finalSpeed * 1, 0f, 1f, 1f);
        wildSchool_Foreground.uvRect = new Rect(wildSchool_Foreground.uvRect.x + finalSpeed * 2, 0f, 1f, 1f);
        wildSchool_Platform.uvRect = new Rect(wildSchool_Platform.uvRect.x + finalSpeed * 3, 0f, 1f, 1f);
    }
    void desactivarTitulo()
    {
        tituloNivel.SetActive(false);
    }
}
