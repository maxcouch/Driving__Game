using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour {

	public float carSpeed;
	public float turnRadius;
	private Rigidbody2D rB;
	
	void Start ( ) {
		rB = GetComponent<Rigidbody2D> ( );
	}
	
	public void MoveForward( ){
		
		rB.velocity += new Vector2 (transform.up.x * carSpeed * Time.deltaTime, transform.up.y * carSpeed * Time.deltaTime);
		
	}
	
	public void Turn(bool left){
		float angle = -turnRadius;
		
		if(left == true)
			angle = turnRadius;
		
		transform.Rotate(0f, 0f, angle);
	}
	
}
