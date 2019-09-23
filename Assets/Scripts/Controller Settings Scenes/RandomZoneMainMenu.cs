using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomZoneMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
	}
		
	public void StartGame(){
		SceneManager.LoadScene ("RandomZone01");
		Time.timeScale = 1;
	}

	public void HowToPlay(){
		SceneManager.LoadScene ("RandomZoneHowToPlay");
	}

	public void Credits(){
		SceneManager.LoadScene ("RandomZoneCredits");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
