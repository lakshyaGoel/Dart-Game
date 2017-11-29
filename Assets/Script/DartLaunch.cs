using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartLaunch : MonoBehaviour {
	public GameObject controllerRight;
	public GameObject projectile;
	public Transform firepoint;
	public float power;
	Rigidbody rb;
	private SteamVR_Controller.Device device;
	private SteamVR_TrackedObject trackedObj;

	public float forceScaleFactor = 100f;

	private Vector3 initPos;
	private float initTime;

	void Start()
	{
		trackedObj = controllerRight.GetComponent<SteamVR_TrackedObject> ();
		device = SteamVR_Controller.Input ((int)trackedObj.index);
	}

	void Update() 
	{
		if (device.GetHairTriggerDown ()) {
			/*this.initPos = this.trackedObj.transform.position;
			this.initTime = Time.time;

		} else if (device.GetHairTriggerUp ()) {
			Vector3 posDiff = this.trackedObj.transform.position - this.initPos;
			float timeDiff = Time.time - this.initTime;*/
			this.ThrowDart ();
		}
	}

	void ThrowDart(){
		GameObject proj = Instantiate (this.projectile);
		proj.transform.position = firepoint.position;
		proj.transform.rotation = firepoint.rotation;
		proj.transform.localScale = new Vector3 (0.05f, 0.05f, 0.05f);
		proj.SetActive (true);

		rb = proj.GetComponent<Rigidbody> ();
		rb.AddForce (firepoint.up * this.forceScaleFactor);
	}
}

	/*void OnCollisionEnter(Collision collision) {
		string tag_name = collision.collider.tag;

		Debug.Log (collision.collider.tag);

		if (collision.collider.tag == "BullsEye") {
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
	

		Debug.Log ("score_count: " + score_count);

		if (collision.collider.tag == "Dartboard") {
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.useGravity = false;
			rb.isKinematic = true;
		}

	}

	void SetScoreText()
	{
		scoreText.text = "Score: " + score_count.ToString ();
	}*/
