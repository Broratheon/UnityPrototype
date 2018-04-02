using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strike_Script : MonoBehaviour {

    public float timeToDisappear = 0.2f;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, timeToDisappear);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dirt")
        {
            Destroy(collision.gameObject);
        }
    }
    
}
