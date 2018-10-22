using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float valueVelocity = 200.0f;
    public Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.left * (4 * valueVelocity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Destroyer"){//Si el objeto con el que se ha detectado el choque es el destructor (identificado mediante su tag)...
            Destroy(gameObject);//Si es así, entonces se destruye el objeto, es decir, el "enemigo" del juego...
        }
    }
}
