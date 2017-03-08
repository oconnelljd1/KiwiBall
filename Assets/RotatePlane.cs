using UnityEngine;
using System.Collections;

public class RotatePlane : MonoBehaviour {

	private float maxRotate = 7.5f;
	private float time;
	private float distanceX;
	private float distanceZ;
	private bool measuredX = false;
	private bool measuredZ = false;
	private bool resetX = true;
	private bool resetZ = true;

	// Use this for initialization
	void Start () {
		maxRotate = maxRotate * Mathf.Deg2Rad;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		/*
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.D)) {
			transform.Rotate (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			Quaternion temp = transform.rotation;
			if (transform.rotation.x > maxRotate) {
				temp.x = maxRotate;
			}
			if (transform.rotation.x < -maxRotate) {
				temp.x = maxRotate * -1;
			}
			if (transform.rotation.z > maxRotate) {
				temp.z = maxRotate;
			}
			if (transform.rotation.z < -maxRotate) {
				temp.z = maxRotate * -1;
			}
			temp.y = 0;
			transform.rotation = temp;
		} else {
			distanceX = transform.rotation.x;

		}
		*/

		Quaternion temp = transform.rotation;
		/*
		if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.S)) {
			resetZ = true;
		} else 
		*/
		if (Input.GetKey (KeyCode.W) ^ Input.GetKey (KeyCode.S)) {
			//Debug.Log("grr");
			resetX = false;
			temp.x +=  Mathf.Deg2Rad * Input.GetAxis("Horizontal");
		} else {
			resetX = true;
		}
		/*
		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.D)) {
			resetX =true;
		} else
		*/
		if (Input.GetKey (KeyCode.D) ^ Input.GetKey (KeyCode.A)) {
			resetZ = false;
			temp.z += 15 * Time.deltaTime * Mathf.Deg2Rad * Input.GetAxis("Vertical");
		} else {
			resetZ = true;
		}

		if (resetZ) {
			ResetZ ();
		}
		if (resetX) {
			ResetX ();
		}

		temp.y = 0;
		transform.rotation = temp;
		Debug.Log (Input.GetAxis ("Vertical") + ", " + Input.GetAxis ("Horizontal"));

	}

	void ResetX(){
		if (!measuredX) {
			distanceX = transform.rotation.x;
			measuredX = true;
		}
		//Debug.Log ("Grrr");
		Quaternion temp = transform.rotation;
		temp.x -= distanceX * Time.deltaTime;
		transform.rotation = temp;
	}

	void ResetZ(){
		if (!measuredZ) {
			distanceZ = transform.rotation.z;
			measuredZ = true;
		}
		Quaternion temp = transform.rotation;
		temp.z -= distanceZ * Time.deltaTime;
		transform.rotation = temp;
	}
}
