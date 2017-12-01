using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

	public Text scoreText; 
	public static int score_count;

	// Use this for initialization
	void Start () {

		score_count = 0;
		SetScoreText ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		string tag_name = collision.collider.tag;
		Rigidbody rb = collision.rigidbody;

		Debug.Log ("HELLO");
		Debug.Log (collision.collider.tag);
		//Debug.Log (tag_name.Substring (0, tag_name.IndexOf ("Point")));

		//int score = int.TryParse(  );
		//Debug.Log ("Score: " + score);

		/*if (collision.collider.tag == "BullsEye") {
			score_count = score_count + 100;
		}
		else if (collision.collider.tag == "1Point") {
			score_count = score_count + 1;
		}
		else if (collision.collider.tag == "2Point") {
			score_count = score_count + 2;
		}
		else if (collision.collider.tag == "3Point") {
			score_count = score_count + 3;
		}
		else if (collision.collider.tag == "4Point") {
			score_count = score_count + 4;
		}
		else if (collision.collider.tag == "5Point") {
			score_count = score_count + 5;
		}
		else if (collision.collider.tag == "6Point") {
			score_count = score_count + 6;
		}
		else if (collision.collider.tag == "7Point") {
			score_count = score_count + 7;
		}
		else if (collision.collider.tag == "8Point") {
			score_count = score_count + 8;
		}
		else if (collision.collider.tag == "9Point") {
			score_count = score_count + 9;
		}
		else if (collision.collider.tag == "10Point") {
			score_count = score_count + 10;
		}
		else if (collision.collider.tag == "11Point") {
			score_count = score_count + 11;
		}
		else if (collision.collider.tag == "12Point") {
			score_count = score_count + 12;
		}
		else if (collision.collider.tag == "13Point") {
			score_count = score_count + 13;
		}
		else if (collision.collider.tag == "14Point") {
			score_count = score_count + 14;
		}
		else if (collision.collider.tag == "15Point") {
			score_count = score_count + 15;
		}
		else if (collision.collider.tag == "16Point") {
			score_count = score_count + 16;
		}
		else if (collision.collider.tag == "17Point") {
			score_count = score_count + 17;
		}
		else if (collision.collider.tag == "18Point") {
			score_count = score_count + 18;
		}
		else if (collision.collider.tag == "19Point") {
			score_count = score_count + 19;
		}
		else if (collision.collider.tag == "20Point") {
			score_count = score_count + 20;
		}
		*/


		Debug.Log ("score_count: " + score_count);

		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
		rb.useGravity = false;
		rb.isKinematic = true;

		SetScoreText ();

	}

	void SetScoreText()
	{
		scoreText.text = "Score: " + score_count.ToString ();
	}
}
