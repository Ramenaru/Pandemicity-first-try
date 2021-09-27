using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackgroundMusic : MonoBehaviour {
	private static BackgroundMusic BGM;

	void Awake() {
		if (BGM == null) {
			BGM = this;
			DontDestroyOnLoad (BGM);

		} else {
			Destroy (gameObject);
		}
	}
}
