using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseGameMenu : MonoBehaviour {
	
	public GameObject Pause;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.Escape)) {

				Pause.SetActive (true);
				Time.timeScale = 0;
				Cursor.visible = true;
		}
	}

	public void ResumeZone(){
		Pause.SetActive (false);
		Time.timeScale = 1;
		Cursor.visible = false;
	}

	public void RestartZone(){
		SceneManager.LoadScene ("RandomZone01");
		Time.timeScale = 1;
	}

	public void MainMenu(){
		SceneManager.LoadScene ("RandomZoneMainMenu");
		Cursor.visible = true;
	}
}