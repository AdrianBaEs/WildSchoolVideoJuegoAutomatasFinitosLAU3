using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    [Range(0.02f, 0.40f)]//Define un rango para controlar el valor de abajo (aplicable para cualquier variable) mediante una barra...
    public float velocidadParallax = 0.02f;
    public RawImage wildSchool_Menu_Foreground, wildSchool_Menu_Platform;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        efectoParallax();
	}
    void efectoParallax()
    {
        float finalSpeed = velocidadParallax * Time.deltaTime;
        wildSchool_Menu_Foreground.uvRect = new Rect(wildSchool_Menu_Foreground.uvRect.x + finalSpeed * 1, 0f, 1f, 1f);
        wildSchool_Menu_Platform.uvRect = new Rect(wildSchool_Menu_Platform.uvRect.x + finalSpeed * 2, 0f, 1f, 1f);
    }
}
