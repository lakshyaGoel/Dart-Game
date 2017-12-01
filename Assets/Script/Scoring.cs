using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

	public static Text scoreText; 
	public static int score_count;

	// Use this for initialization
	void Start () {

		score_count = 0;
		//SetScoreText ();
		scoreText.text = "Score: " + score_count.ToString ();
	}

	// Update is called once per frame
	void Update () {
		//SetScoreText ();

	}
		
	/*void SetScoreText()
	{
		scoreText.text = "Score: " + score_count.ToString ();
	}
	*/
}
