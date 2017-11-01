using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartLaunch : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public float strength = 1;
	public Transform direction = null;

	// Use this for initialization
	void Start(){
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");


		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		if (this.direction != null) {
			rb.AddForce (direction.rotation * strength, ForceMode.Impulse);
		}
	}
}
