using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerGame : MonoBehaviour {

	public Text Timer;
	public float timer_Game = 60;
	public GameObject GameOver;


	// Use this for initialization
	void Start () {
		TimerScene ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		TimerScene ();

		if (timer_Game < 0) {
			Time.timeScale = 0;
			GameOver.SetActive (true);
			Cursor.visible = true;
		}
	}

	public void TryAgain(){
		SceneManager.LoadScene ("RandomZone01");
		Time.timeScale = 1;
	}

	public void MainMenu(){
		SceneManager.LoadScene ("RandomZoneMainMenu");
		Cursor.visible = true;
	}

	void TimerScene(){
		Timer.text = "Time: " + timer_Game.ToString ("f0");
	}

}
