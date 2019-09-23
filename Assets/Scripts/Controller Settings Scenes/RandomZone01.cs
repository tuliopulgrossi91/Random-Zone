using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomZone01 : MonoBehaviour {

		public GameObject CountDown;
		public Text Count;
		public float count_Down = 3;
		public GameObject Player1;
		public TimerGame timer;

		// Use this for initialization
		void Start () {
			Cursor.visible = false;
			
		}

		// Update is called once per frame
		void FixedUpdate () {

		count_Down -= Time.deltaTime;
		CountUtil ();

		if (count_Down > 0) {
			Player1.SetActive (false);
		}

		if (count_Down < 0) {
			CountDown.SetActive (false);
			Player1.SetActive (true);
			timer.timer_Game -= Time.deltaTime;
		}
	}

	void CountUtil(){
		Count.text = " " + count_Down.ToString ("f0");
	}
	}
