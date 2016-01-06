using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rbody;
	Animator anim;

	// Use this for initialization
	void Start () {

		// Call components for variables
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		// Get vertical and horizontal movement variables
		Vector2 movement_vector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		// Test if character is moving 
		if (movement_vector != Vector2.zero) {
			anim.SetBool ("iswalking", true);
			anim.SetFloat ("input_x", movement_vector.x);
			anim.SetFloat ("input_y", movement_vector.y);
		} else {
			anim.SetBool ("iswalking", false);
		}

		// Move character possition
		rbody.MovePosition (rbody.position + movement_vector * Time.deltaTime);
	}
}
