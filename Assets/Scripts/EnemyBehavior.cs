using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	//call variables
	private Vector3 Player;
	private Vector2 PlayerDirection;
	private float XDif;
	private float YDif;
	public float speed;
	private int Wall;


	void Start (){
		Wall = 1 << 8;
	}

	// Update is called once per frame
	void Update () {
	
		//Find player position
		Player = GameObject.Find ("Player").transform.position;

		//Find diffence betweeen player and enemy
		XDif = Player.x - transform.position.x;
		YDif = Player.y - transform.position.y;

		PlayerDirection = new Vector2 (XDif, YDif);

		//Move towards player postion
		if (!Physics2D.Raycast (transform.position, PlayerDirection, 1, Wall)) {
			GetComponent<Rigidbody2D> ().AddForce (PlayerDirection.normalized * speed);
		
		}
	}
}