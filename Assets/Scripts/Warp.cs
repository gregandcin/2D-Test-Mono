using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

	//call variables
	public Transform warpTarget;

	IEnumerator OnTriggerEnter2D(Collider2D other){

		//call ScreenFader object
		ScreenFader sf = GameObject.FindGameObjectWithTag ("Fader").GetComponent<ScreenFader> ();

		//Call FadeToBlack when colliding with warp exit
		yield return StartCoroutine (sf.FadeToBlack ());

		Debug.Log ("An object Collided.");

		//Move player and camera to warp exit
		other.gameObject.transform.position = warpTarget.position;
		Camera.main.transform.position = warpTarget.position;

		//Call FadeToClear when Player and Camera have moved
		yield return StartCoroutine (sf.FadeToClear ());
	}

}
