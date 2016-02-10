using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	bool forwardPressed;
	bool leftPressed;
	bool rightPressed;

	CarScript carScript;

	void Start () {
		carScript = GetComponent<CarScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw ("Vertical") > 0f) {
			forwardPressed = true;
		} else
			forwardPressed = false;
	}

		if (Input.GetAxisRaw ("Horizontal") > 0f) {
			rightPressed = true;
		} else
			rightPressed = false;


if (Input.GetAxisRaw ("Horizontal") > 0f) {
			rightPressed = true;
		} else
			rightPressed = false;

		if (Input.GetAxisRaw ("Horizontal") > 0f) {
			leftPressed = true;
		} else
			leftPressed = false;


	void FixedUpdate(){
		if (forwardPressed)
			carScript.MoveForward ();

		if (rightPressed)
			carScript.MoveForward ();

		if (leftPressed)
			carScript.MoveForward ();
	}
}

