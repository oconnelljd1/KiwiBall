using UnityEngine;
using System.Collections;

public class WorldController : MonoBehaviour {

	private bool resetX;
	private bool resetZ;

	[SerializeField]
	private GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		/*
		if (Input.GetAxis("Vertical") != 0) {
			transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (10 * Input.GetAxis ("Vertical") * Mathf.Acos (player.transform.rotation.y), 0, 10 * Input.GetAxis ("Vertical") * Mathf.Asin (player.transform.rotation.y)), 15 * Mathf.Deg2Rad);
		} else if (Input.GetAxis("Horizontal") != 0) {
			transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (10 * Input.GetAxis ("Horizontal") * Mathf.Asin (player.transform.rotation.y), 0, 10 * Input.GetAxis ("Horizontal") * Mathf.Acos(player.transform.rotation.y)), 15 * Mathf.Deg2Rad);
		} else {
			transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (0, 0, 0), 15 * Mathf.Deg2Rad);
		}
		*/
		/*
		if ((Input.GetAxis("Horizontal") != 0) && (Input.GetAxis("Vertical") != 0)) {
			//do nothing
		} else*/ 
		///*
		if (Input.GetAxis("Vertical") != 0) {
				transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (10 * Input.GetAxis ("Vertical") * Mathf.Cos (player.transform.eulerAngles.y * Mathf.Deg2Rad), 0, 10 * Input.GetAxis ("Vertical") * Mathf.Sin (player.transform.eulerAngles.y * Mathf.Deg2Rad + Mathf.PI)), 15 * Mathf.Deg2Rad);
		} else if (Input.GetAxis("Horizontal") != 0) {
				transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (10 * Input.GetAxis ("Horizontal") * Mathf.Sin (player.transform.eulerAngles.y * Mathf.Deg2Rad + Mathf.PI), 0, 10 * Input.GetAxis ("Horizontal") * Mathf.Cos(player.transform.eulerAngles.y * Mathf.Deg2Rad + Mathf.PI)), 15 * Mathf.Deg2Rad);
		} else {
			transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (0, 0, 0), 15 * Mathf.Deg2Rad);
		}
		//*/
		Debug.Log (Mathf.Sin(player.transform.rotation.y));

		//***transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (10 * Input.GetAxis("Vertical"), 0, 10 * Input.GetAxis("Horizontal")), 15 * Mathf.Deg2Rad);
		//transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (0, 0, 0), 0);

		/*
		Quaternion tempR = transform.localRotation;
		//tempR.x += Mathf.Deg2Rad * Input.GetAxis ("Vertical") * Time.deltaTime * 15;
		//tempR.z += Mathf.Deg2Rad * Input.GetAxis ("Horizontal") * Time.deltaTime * -15;
		if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S)){
			tempR.x += Mathf.Deg2Rad * Input.GetAxis ("Vertical") * Time.deltaTime * 15 * Mathf.Cos (player.transform.localRotation.y);
			tempR.z += Mathf.Deg2Rad * Input.GetAxis ("Horizontal") * Time.deltaTime * -15 * Mathf.Sin(player.transform.localRotation.y);
			//Debug.Log (Mathf.Sin (player.transform.localRotation.y));
			//Debug.Log (Mathf.Cos (player.transform.localRotation.y));
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)) {
			tempR.x += Mathf.Deg2Rad * Input.GetAxis ("Vertical") * Time.deltaTime * 15 * Mathf.Sin (player.transform.localRotation.y);
			tempR.z += Mathf.Deg2Rad * Input.GetAxis ("Horizontal") * Time.deltaTime * -15 * Mathf.Cos(player.transform.localRotation.y);
			//Debug.Log (Mathf.Sin (player.transform.localRotation.y));
			//Debug.Log (Mathf.Cos (player.transform.localRotation.y));
		}

		//Debug.Log (Mathf.Sin (player.transform.localRotation.y));
		if (tempR.x > 5 * Mathf.Deg2Rad) {
			tempR.x = 5 * Mathf.Deg2Rad;
			//Debug.Log ("Hey");
		}
		if (tempR.x < -5 * Mathf.Deg2Rad) {
			tempR.x = -5 * Mathf.Deg2Rad;
			//Debug.Log ("Hey");
		}
		if (tempR.z > 5 * Mathf.Deg2Rad) {
			tempR.z = 5 * Mathf.Deg2Rad;
			//Debug.Log ("Hey");
		}
		if (tempR.z < -5 * Mathf.Deg2Rad) {
			tempR.z = -5 * Mathf.Deg2Rad;
			//Debug.Log ("Hey");
		}
		*/
		/*
		if (tempR.x > Mathf.Cos (player.transform.localRotation.y) * 15) {
			tempR.x = Mathf.Cos (player.transform.localRotation.y) * 15;
			Debug.Log ("Hey");
		}
		if (tempR.x < Mathf.Cos (player.transform.localRotation.y) * -15) {
			tempR.x = Mathf.Cos (player.transform.localRotation.y) * -15;
			Debug.Log ("Hey");
		}
		if (tempR.z > Mathf.Sin (player.transform.localRotation.y) * 15) {
			tempR.z = Mathf.Sin (player.transform.localRotation.y) * 15;
			Debug.Log ("Hey");
		}
		if (tempR.z < Mathf.Sin (player.transform.localRotation.y) * -15) {
			tempR.z = Mathf.Sin (player.transform.localRotation.y) * -15;
			Debug.Log ("Hey");
		}
		*/
		//transform.localRotation = tempR;
		/*
		if (Input.GetKey (KeyCode.W) == Input.GetKey (KeyCode.S)) {
			ResetX ();
		}

		if (Input.GetKey (KeyCode.A) == Input.GetKey (KeyCode.D)) {
			ResetZ ();
		}

	}

	private void ResetX(){
		transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (0, 0, transform.rotation.z), 15 * Mathf.Deg2Rad);
	}

	private void ResetZ(){
		transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (transform.rotation.x, 0, 0), 15 * Mathf.Deg2Rad);
	*/
	}
}