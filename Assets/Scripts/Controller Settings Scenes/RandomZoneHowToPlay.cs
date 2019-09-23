using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomZoneHowToPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
	}

	public void BackToMainMenu(){
		SceneManager.LoadScene ("RandomZoneMainMenu");
	}

	// Update is called once per frame
	void Update () {
		
}
}