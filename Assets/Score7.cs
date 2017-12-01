using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score7 : MonoBehaviour {
	public Text Score7text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "Dart") {

			Scoring.score_count += 7;
			Debug.Log ("Hit 7");
			Debug.Log (Scoring.score_count);

			Rigidbody rb = collision.rigidbody;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.useGravity = false;
			rb.isKinematic = true;

			Score7text.text = "Score: " + Scoring.score_count.ToString();
		}

	}
}
