﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Score9 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "Dart") {

			Scoring.score_count += 9;
			Debug.Log ("Hit 9");
			Debug.Log (Scoring.score_count);
		}

	}
}