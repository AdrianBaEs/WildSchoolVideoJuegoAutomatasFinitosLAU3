using UnityEngine;
using System.Collections;

public class movEnemigo : MonoBehaviour {

    public float moveSpeed = 70f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "destructorEnemigos")
        {
            Destroy(this.gameObject);
        }
    }
}
