using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour {

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	
	}
	private void OnTriggerEnter2D(Collider2D collision) {

		if (collision.tag == "Border") {
			Destroy (this.gameObject);
		} else if (collision.tag == "Player") {
			Destroy(player.gameObject);
		}
	}

}
 