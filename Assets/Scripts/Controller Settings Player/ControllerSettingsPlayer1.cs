using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerSettingsPlayer1 : MonoBehaviour {

	public float move_Speed_Player1 = 25f;
	
	public Text score_Text;
	private int score_Player1 = 0;

	public GameObject PickUp1;
	public GameObject PickUp2;
	public GameObject PickUp3;
	public GameObject PickUp4;
	public GameObject PickUp5;
	public GameObject PickUp6;
	public GameObject PickUp7;
	public GameObject PickUp8;
	public GameObject PickUp9;
	public GameObject PickUp10;

	public GameObject Teleport1;
	public GameObject Teleport2;
	public GameObject Teleport3;
	public GameObject Teleport4;
	public GameObject Teleport5;
	public GameObject Teleport6;
	public GameObject Teleport7;
	public GameObject Teleport8;
	public GameObject Teleport9;
	public GameObject Teleport10;

	public TimerGame Timer;
	public GameObject WinGame;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		ScorePlayer1 ();
	}
	
	// Update is called once per frame
	void Update () {
		P1ControllerDefault ();
	}

	void P1ControllerDefault(){
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.Keypad8)) {
			transform.Translate (Vector3.forward * move_Speed_Player1 * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.Keypad5)) {
			transform.Translate (-Vector3.forward * move_Speed_Player1 * Time.deltaTime);
		}else if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.Keypad4)) {
			transform.Translate (Vector3.left * move_Speed_Player1 * Time.deltaTime);
		}else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.Keypad6)) {
			transform.Translate (Vector3.right * move_Speed_Player1 * Time.deltaTime);
		}
	}

	void OnTriggerEnter(Collider col){
		
		if (col.gameObject.CompareTag ("Pick Up")) {
			col.gameObject.SetActive (false);
			score_Player1++;
			ScorePlayer1 ();
		}

			switch(score_Player1){

				case 1:
					Timer.timer_Game = Timer.timer_Game / 2;
					move_Speed_Player1++;
				break;

				case 2:
					Timer.timer_Game = Timer.timer_Game * 2;
					move_Speed_Player1--;
				break;

				case 3:
					Timer.timer_Game = Timer.timer_Game * 2;
					move_Speed_Player1++;
				break;

				case 4:
					Timer.timer_Game = Timer.timer_Game * 2;
					move_Speed_Player1++;
				break;

				case 5:
					Timer.timer_Game = Timer.timer_Game / 2;
					move_Speed_Player1++;
				break;

				case 6:
					Timer.timer_Game = Timer.timer_Game * 2;
					move_Speed_Player1--;
				break;

				case 7:
					Timer.timer_Game = Timer.timer_Game / 2;
					move_Speed_Player1++;
				break;

				case 8:
					Timer.timer_Game = Timer.timer_Game / 2;
					move_Speed_Player1++;
				break;

				case 9:
					Timer.timer_Game = Timer.timer_Game / 2;
					move_Speed_Player1--;
				break;

				case 10:
					Time.timeScale = 0;
					WinGame.SetActive (true);
					Cursor.visible = true;
				break;
					default:
				break;
			}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.CompareTag ("Enemy1") || col.gameObject.CompareTag ("Enemy2") ||
			col.gameObject.CompareTag ("Enemy3") || col.gameObject.CompareTag ("Enemy4") || 
			col.gameObject.CompareTag ("Enemy5") || col.gameObject.CompareTag ("Enemy6") ||
			col.gameObject.CompareTag ("Enemy7") || col.gameObject.CompareTag ("Enemy8") ||
			col.gameObject.CompareTag ("Enemy9") || col.gameObject.CompareTag ("Enemy10")||
			col.gameObject.CompareTag ("Enemy11") || col.gameObject.CompareTag ("Enemy12")) {

			transform.position = new Vector3 (0.5f, 3f, -35f);
			PickUp1.SetActive (true);
			PickUp2.SetActive (true);
			PickUp3.SetActive (true);
			PickUp4.SetActive (true);
			PickUp5.SetActive (true);
			PickUp6.SetActive (true);
			PickUp7.SetActive (true);
			PickUp8.SetActive (true);
			PickUp9.SetActive (true);
			PickUp10.SetActive (true);
			score_Player1 = 0;
			ScorePlayer1 ();

		}
	}

	void OnCollisionStay(Collision col2){
		if (col2.gameObject.CompareTag ("Teleport1")) {
			transform.position = new Vector3 (-41.96f, 6.3f, -13.5f);
		}

		if (col2.gameObject.CompareTag ("Teleport3")) {
			transform.position = new Vector3 (-42.13f, 3.06f, 41.5f);
		}

		if (col2.gameObject.CompareTag ("Teleport5")) {
			transform.position = new Vector3 (43.9f, 4.85f, 23.97f);
		}

		if (col2.gameObject.CompareTag ("Teleport7")) {
			transform.position = new Vector3 (4.67f, 4.85f, 45.77f);
		}

		if (col2.gameObject.CompareTag ("Teleport9")) {
			transform.position = new Vector3 (32.77f, 4.85f, 34.91f);
		}
	}

	void ScorePlayer1(){
		score_Text.text = "Score: " + score_Player1.ToString ();
	}
}