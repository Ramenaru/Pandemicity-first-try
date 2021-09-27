using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	[SerializeField] GameObject PM;

	public void Pause() {
		PM.SetActive (true);
		Time.timeScale = 0f;
	}

	public void Resume () {
		PM.SetActive (false);
		Time.timeScale = 1f;
	}

	public void Home(int sceneID) {
		Time.timeScale = 1f;
		SceneManager.LoadScene (sceneID);
	}
}