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
