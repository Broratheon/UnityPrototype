using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour {

    public float speed = 1.0f;
    public Transform AttackObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CharacterMoveSet();
    }

    private void CharacterMoveSet()
    {
        if (Input.GetKey("s"))
            transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (Input.GetKey("a"))
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (Input.GetKey("d"))
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey("w"))
            transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (Input.GetKey("space"))
            Instantiate(AttackObject, transform.position + Vector3.right, Quaternion.identity);

    }

}
