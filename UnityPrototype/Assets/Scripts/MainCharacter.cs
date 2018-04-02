using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour {

    public float speed = 1.0f;
    public GameObject AttackObject;
    public float attackSpeed = 0.4f;

    private Dictionary<string, Vector3> KeyToActionMap = new Dictionary<string, Vector3>  { { "w", Vector3.up },
                                                                                            { "a", Vector3.left },
                                                                                            { "s", Vector3.down },
                                                                                            { "d", Vector3.right } };
    private float attackTimer = 100000f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ReactToKeyPress();
    }

    private void ReactToKeyPress() {
        attackTimer += Time.deltaTime;

        CharacterMovement();

        if (Input.GetKey("space") && attackTimer > attackSpeed)
        {
            Instantiate(AttackObject, transform.position + (Vector3.right * 1.5f), Quaternion.identity);
            attackTimer = 0;
        }
    }

    // Handles movmement of the character
    private void CharacterMovement() {
        foreach (KeyValuePair<string, Vector3> mapping in KeyToActionMap)
        {
            if (Input.GetKey(mapping.Key))
                transform.Translate(mapping.Value * speed * Time.deltaTime);
        }
    }
}
