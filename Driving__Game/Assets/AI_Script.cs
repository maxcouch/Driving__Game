using UnityEngine;
using System.Collections;

public class AI_Script : MonoBehaviour {

	CarScript carScript;

	// Use this for initialization
	void Start () {
		carScript = GetComponent<CarScript> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		carScript.MoveForward ();
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.CompareTag ("OutsideCollider")) {
			carScript.Turn (false);
		}

		if (collider.CompareTag ("InsideCollider")) {
			carScript.Turn (true);
		}
	}
}
