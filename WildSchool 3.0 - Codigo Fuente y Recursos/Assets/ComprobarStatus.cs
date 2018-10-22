using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarStatus : MonoBehaviour {

    private int contadorNiveles=0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public int pasarSiguienteNivel(){
        contadorNiveles = contadorNiveles + 1;
        return contadorNiveles;
    }
    public int repetirMismoNivel(){
        return contadorNiveles;
    }
}
