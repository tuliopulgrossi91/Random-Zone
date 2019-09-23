using UnityEngine;
using System.Collections;

public class ControllerSettingsEnemy1 : MonoBehaviour {

	private GameObject Enemy1;
	private GameObject Enemy2;
	private GameObject Enemy3;
	private GameObject Enemy4;
	private GameObject Enemy5;
	private GameObject Enemy6;
	private GameObject Enemy7;
	private GameObject Enemy8;
	private GameObject Enemy9;
	private GameObject Enemy10;
	private GameObject Enemy11;
	private GameObject Enemy12;

	private Rigidbody rb3D;
		
	// Use this for initialization
	void Start () {
			
		rb3D = GetComponent<Rigidbody> ();
		MoveEnemys ();
	}

	void MoveEnemys(){


		if(gameObject.CompareTag("Enemy1")){
			MoveUp ();
		}

		if(gameObject.CompareTag("Enemy2")){
			MoveUp ();
		}

		if(gameObject.CompareTag("Enemy3")){
			MoveLeft ();
		}

		if(gameObject.CompareTag("Enemy4")){
			MoveDown ();
		}

		if(gameObject.CompareTag("Enemy5")){
			MoveZUp ();
		}

		if(gameObject.CompareTag("Enemy6")){
			MoveZUp ();
		}
			
		if(gameObject.CompareTag("Enemy7")){
			MoveZDown ();
		}

		if(gameObject.CompareTag("Enemy8")){
			MoveZDown ();
		}

		if(gameObject.CompareTag("Enemy9")){
			MoveRight ();
		}

		if(gameObject.CompareTag("Enemy10")){
			MoveLeft ();
		}

		if(gameObject.CompareTag("Enemy11")){
			MoveRight ();
		}

		if(gameObject.CompareTag("Enemy12")){
			MoveLeft ();
		}
	}


	void MoveUp(){
		rb3D.velocity = new Vector2 (0, 15);
		Invoke ("MoveDown", 3);
	}

	void MoveDown(){
		rb3D.velocity = new Vector2 (0, -15);
		Invoke ("MoveUp", 3);
	}

	void MoveZUp(){
		rb3D.velocity = new Vector3 (0, 0, 30);
		Invoke ("MoveZDown", 2);
	}

	void MoveZDown(){
		rb3D.velocity = new Vector3 (0, 0, -30);
		Invoke ("MoveZUp", 2);
	}

	void MoveLeft () {
		rb3D.velocity = new Vector2 (-60, 0);
		Invoke ("MoveRight", 5);
	}

	void MoveRight () {
		rb3D.velocity = new Vector2 (60, 0);
		Invoke ("MoveLeft", 5);
	}
}