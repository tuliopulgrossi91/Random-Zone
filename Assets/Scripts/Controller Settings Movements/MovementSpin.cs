using UnityEngine;
using System.Collections;

public class MovementSpin : MonoBehaviour {

	public float speedSpin = 5f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate (Vector3.up, speedSpin * Time.deltaTime);
	}
}
