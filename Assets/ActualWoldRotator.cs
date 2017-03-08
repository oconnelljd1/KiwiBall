using UnityEngine;
using System.Collections;

public class ActualWoldRotator : MonoBehaviour {

	[SerializeField]
	private GameObject player;

	private Rigidbody myRB;
	private Vector3 original;

	// Use this for initialization
	void Start () {
		myRB = player.transform.parent.gameObject.GetComponent<Rigidbody> ();
		original = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		myRB.AddForce(Vector3.down);

		if (Input.GetAxis("Vertical") != 0) {
			transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (10 * Input.GetAxis ("Vertical") * Mathf.Cos (player.transform.eulerAngles.y * Mathf.Deg2Rad), 0, 10 * Input.GetAxis ("Vertical") * Mathf.Sin (player.transform.eulerAngles.y * Mathf.Deg2Rad + Mathf.PI)), 15 * Mathf.Deg2Rad);
		} else if (Input.GetAxis("Horizontal") != 0) {
			transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (10 * Input.GetAxis ("Horizontal") * Mathf.Sin (player.transform.eulerAngles.y * Mathf.Deg2Rad + Mathf.PI), 0, 10 * Input.GetAxis ("Horizontal") * Mathf.Cos(player.transform.eulerAngles.y * Mathf.Deg2Rad + Mathf.PI)), 15 * Mathf.Deg2Rad);
		} else {
			transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (0, 0, 0), 15 * Mathf.Deg2Rad);
		}
		/*
		Vector3 temp = transform.position;
		temp.y = (player.transform.position.y - transform.position.y) - (Mathf.Tan (transform.eulerAngles.x) * player.transform.position.x + Mathf.Tan (transform.eulerAngles.z) * player.transform.position.z + transform.position.y);
		transform.position = temp;
		*/
		/*
		Vector3 tempPlayer = player.transform.parent.position;
		tempPlayer.y = 0.5f;
		player.transform.parent.position = tempPlayer;

		Vector3 temp = original;
		temp.y = Mathf.Tan(transform.eulerAngles.x * Mathf.Deg2Rad) * player.transform.position.x + Mathf.Tan(transform.eulerAngles.z * Mathf.Deg2Rad) * player.transform.position.z;
		transform.position = temp;
		*/
		///*
		/*
		Vector3 tempPlayer = player.transform.parent.position;
		tempPlayer.y = 0.5f;
		player.transform.parent.position = tempPlayer;
		*/
		/*
		Vector3 temp = original;
		temp.y = player.transform.position.y - 0.5f + Mathf.Tan(transform.eulerAngles.x * Mathf.Deg2Rad) * player.transform.position.x + Mathf.Tan(transform.eulerAngles.z * Mathf.Deg2Rad) * player.transform.position.z;
		transform.position = temp;
		*/
		///*
		Vector3 temp = original;
		temp.y = (player.transform.position.y - 0.5f - transform.position.y) - (Mathf.Tan (transform.eulerAngles.x) * player.transform.position.x + Mathf.Tan (transform.eulerAngles.z) * player.transform.position.z);
		transform.position = temp;
		//*/

		player.transform.eulerAngles = new Vector3 (0, Mathf.Atan2 (myRB.velocity.x, myRB.velocity.z) * Mathf.Rad2Deg, 0);
		//Debug.Log (Mathf.Sin(player.transform.rotation.y));
	}
}
