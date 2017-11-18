using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartLaunch : MonoBehaviour {

	private Rigidbody rb;
	public GameObject controllerRight;

	private SteamVR_Controller.Device device;
	private SteamVR_TrackedController controller;
	private SteamVR_TrackedObject trackedObj;


	// Use this for initialization
	void Start(){
		rb = GetComponent<Rigidbody> ();
		controller = controller.GetComponent<SteamVR_TrackedController> ();
		controller.TriggerClicked += TriggerPressed;
		trackedObj = controllerRight.GetComponent<SteamVR_TrackedObject> ();
	}

	private void TriggerPressed(object sender, ClickedEventArgs e){
		ThrowDart ();
	}
	// Update is called once per frame
	void Update () {
		
	}

	void ThrowDart(){
		//Vector3 movement = new Vector3 (-1.0f, 0.0f, 0.0f);

		//if(Input.GetKeyDown(KeyCode.Space)){
			rb.velocity = new Vector3(-20, 0, 0);
			rb.useGravity = true;
		//}
	}

	void FixedUpdate(){
		
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log (collision.collider.tag);
		if (collision.collider.tag == "Dartboard") {
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.useGravity = false;
			rb.isKinematic = true;
		}

	}
}
