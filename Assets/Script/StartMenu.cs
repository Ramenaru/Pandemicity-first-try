using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ketujuan(int yangdituju) {
		Application.LoadLevel (yangdituju);
		
	}
}
