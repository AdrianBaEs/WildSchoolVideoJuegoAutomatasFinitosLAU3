using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarDos : MonoBehaviour {

    public int contadorNiveles2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public int pasarSiguienteNivel()
    {
        contadorNiveles2 = contadorNiveles2 + 1;
        //comprobarDos.contadorNiveles2 = contadorNiveles2;
        return contadorNiveles2;
    }
    public int repetirMismoNivel()
    {
        return contadorNiveles2;
    }
}
