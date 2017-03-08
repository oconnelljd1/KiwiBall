using UnityEngine;
using System.Collections;

public class PlayerCOntroller : MonoBehaviour {

	private Rigidbody myRB;
	private float myDirection;
	private int rotateSpeed = 30;
	private Vector3 pos;

	// Use this for initialization
	void Start () {
		myRB = transform.parent.gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		myRB.AddForce (Vector3.down * 2);
		pos.x = myRB.velocity.x;
		pos.y = myRB.velocity.y;
		pos.z = myRB.velocity.z;
		//pos.x = 0;
		//pos.y = 0;
		//pos.z = 0;
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (pos), rotateSpeed * Time.deltaTime);	
		//transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (myRB.velocity), rotateSpeed * Time.deltaTime);
		//transform.rotation = Quaternion.LookRotation (myRB.velocity);
		//transform.rotation = Quaternion.SetLookRotation (myRB.velocity, Vector3.up);
		//myDirection = Mathf.Atan2 (myRB.velocity.x, myRB.velocity.z);
		//Debug.Log (myDirection);
		//transform.localRotation = Quaternion.RotateTowards (transform.localRotation, Quaternion.Euler (myRB.velocity.x, myRB.velocity.y, myRB.velocity.z), 45);
		//	transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (0, transform.rotation.y + Input.GetAxis("Horizontal"), 0), 360 * Time.deltaTime);
		/*
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
			transform.Rotate(Vector3.up * Input.GetAxis("Horizontal"));
		}
		*/
		/*
		Quaternion tempLR = transform.localRotation;
		tempLR.y += Input.GetAxis ("Horizontal") * Mathf.Deg2Rad * 45 * Time.deltaTime ;
		if(Input.GetKeyDown(KeyCode.S)){
			tempLR.y = tempLR.y + (180 * Mathf.Deg2Rad);
		}

		transform.localRotation = tempLR;
		*/ /*
		Quaternion tempR = transform.rotation;
		tempR.x = 0;
		tempR.z = 0;
		transform.rotation = tempR;
		*/
	}
}
