using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartLaunch : MonoBehaviour {

	private Rigidbody rb;
	public float strength = 1000000;

	// Use this for initialization
	void Start(){
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		Vector3 movement = new Vector3 (-1.0f, 0.0f, 0.0f);

		if(Input.GetKeyDown(KeyCode.Space)){
			
			rb.AddForce(movement * strength, ForceMode.Impulse);
			rb.useGravity = true;
		}
	}
}
