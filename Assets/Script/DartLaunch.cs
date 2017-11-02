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

		direction = this.transform;

		if(Input.GetKeyDown(KeyCode.Space)){
			Vector3 movement = new Vector3 (-1.0f, 0.0f, 0.0f);
			rb.AddForce(movement * strength, ForceMode.Impulse);
		}
	}
}
