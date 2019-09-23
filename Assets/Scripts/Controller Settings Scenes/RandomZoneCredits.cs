using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomZoneCredits : MonoBehaviour {

	public GameObject Cam;
	private int speed_Text = 50;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		Cam.transform.Translate (Vector3.down * Time.deltaTime * speed_Text);
		StartCoroutine (Wait ());
	}

	IEnumerator Wait(){
	
		yield return new WaitForSeconds (25);
		SceneManager.LoadScene ("RandomZoneMainMenu");

	}
}
