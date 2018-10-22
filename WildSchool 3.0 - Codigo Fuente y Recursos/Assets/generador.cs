using UnityEngine;
using System.Collections;
using System;

public class generador : MonoBehaviour {
    
    public float moveSpeed =25f;//Velocidad del movimiento del objeto generador de enemigos...
    private int mov = 2;
    private int bloq = 0;
    genVerdadero g;//Instancia del objeto hijo del generador...
    // Use this for initialization
    void Start () {
        g = transform.GetChild(0).GetComponent<genVerdadero>();//Así se relaciona el objeto con la clase, cuando es declarada sobre el objeto padre...
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) & bloq==0)
        {
            mov = 1;
            bloq = 1;
        }
        //Movimientos
        if (mov==1)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        if (mov==0)
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("limSuperior")) {
            g.generar = 1;//Cada vez que choque con el objeto con collider de etiqueta "limSuperior", cambia el valor a 1 y esto significa generar enemigo... 
            mov = 0;
        }

        if (other.CompareTag("limInferior")) {
            g.generar = 1;//Cada vez que choque con el objeto con collider de etiqueta "limInferior", cambia el valor a 1 y esto significa generar enemigo...
            mov = 1;
        }
    }
}
