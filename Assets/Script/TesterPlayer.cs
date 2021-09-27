using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TesterPlayer : MonoBehaviour {

	public int kecepatan;
	public bool tombolAtas;
	public bool tombolBawah;

	void Update() {
		if (Input.GetKey (KeyCode.W) || (tombolAtas==true)) {
			transform.Translate (Vector2.up * kecepatan * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.S) || (tombolBawah==true)) {
			transform.Translate (Vector2.up * -kecepatan * Time.deltaTime);

		}
	}

	public void tekanatas() {
		tombolAtas = true;
	}
	public void lepasatas() {
		tombolAtas = false;
    }
	public void tekanbawah() {
		tombolBawah = true;
	}
	public void lepasbawah() {
		tombolBawah = false;
	}

}