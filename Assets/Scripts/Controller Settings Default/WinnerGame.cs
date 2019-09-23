using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinnerGame : MonoBehaviour {

	public GameObject WinGame;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TryAgain(){
		SceneManager.LoadScene ("RandomZone01");
		Time.timeScale = 1;
	}

	public void MainMenu(){
		SceneManager.LoadScene ("RandomZoneMainMenu");
		Cursor.visible = true;
	}
}
