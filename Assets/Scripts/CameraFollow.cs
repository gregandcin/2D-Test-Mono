using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	//Call varibales
	public Transform target;
	public float m_speed = 0.1f;
	Camera mycam;

	// Use this for initialization
	void Start () {
	
		// calls camera for mycam variable
		mycam = GetComponent<Camera> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		// Set size of camera
		mycam.orthographicSize = (Screen.height / 100f) / 1.5f;

		if (target) {

			// Have camera follow player
			transform.position = Vector3.Lerp (transform.position, target.position, m_speed) + new Vector3(0, 0, -10);

		}

	}
}
