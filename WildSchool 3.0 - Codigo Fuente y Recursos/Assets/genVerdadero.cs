using UnityEngine;
using System.Collections;

public class genVerdadero : MonoBehaviour {
    public GameObject enemigo1;
    public float tiempoAire = 0;
    public int generar=0;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (generar == 1)//Cada vez que el valor de la variable "generar" cambie a 1, se genera un nuevo enemigo...
        {
            Instantiate(enemigo1, transform.position, Quaternion.identity);
            generar = 0;//Se cambia el valor a 0 hasta que vuelva a chocar el generador con otro collider (ahí se convierte nuevamente en 1)...
        }

    }
    
}
