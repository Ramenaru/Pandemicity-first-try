﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnObstacle : MonoBehaviour {

	public GameObject obstacle;
	public float maxX;
	public float minX;
	public float maxY;
	public float minY;
	public float timeBeetweenSpawn;
	private float spawnTime;


	
	// Update is called once per frame
	void Update () {
		if (Time.time > spawnTime) {
			spawn();
			spawnTime = Time.time + timeBeetweenSpawn;
		}
	
	}

	void spawn () {

		float randomX = Random.Range (minX, maxX);
		float randomY = Random.Range (minY, maxY);

		Instantiate (obstacle, transform.position + new Vector3 (randomX, randomY, 0), transform.rotation);
	}
}
