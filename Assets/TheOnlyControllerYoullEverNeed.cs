using UnityEngine;
using System.Collections;

public class TheOnlyControllerYoullEverNeed : MonoBehaviour {

	private Rigidbody myRB;
	private float myDirection;
	//private int rotateSpeed = 1;
	private Vector3 pos;

	[SerializeField]
	private float worldSpeed = 1;

	[SerializeField]
	private GameObject world;

	// Use this for initialization
	void Start () {
		myRB = transform.parent.gameObject.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

		myRB.AddForce (Vector3.down * 2);

		transform.eulerAngles = new Vector3 (0, Mathf.Atan2 (myRB.velocity.x, myRB.velocity.z) * Mathf.Rad2Deg, 0);

		Vector3 pivot = transform.position;
		pivot.y = transform.position.y - 0.5F;

		world.transform.RotateAround (pivot, transform.right, 2 * worldSpeed * Time.deltaTime * Input.GetAxis ("Vertical"));
		world.transform.RotateAround (pivot, transform.forward, 2 * worldSpeed * Time.deltaTime * -Input.GetAxis ("Horizontal"));

		Vector3 worldRot = world.transform.eulerAngles;

		if((worldRot.x > 10 && worldRot.x < 180)||(worldRot.x < 350 && worldRot.x > 180)||(worldRot.z > 10 && worldRot.z < 180)||(worldRot.z < 350 && worldRot.z > 180)){
			world.transform.RotateAround (pivot, transform.right, worldSpeed * Time.deltaTime * -Input.GetAxis ("Vertical"));
			world.transform.RotateAround (pivot, transform.forward, worldSpeed * Time.deltaTime * Input.GetAxis ("Horizontal"));
		}

		if(worldRot.x > 180){
			world.transform.RotateAround (pivot, world.transform.right, worldSpeed * Time.deltaTime);
		}else if(worldRot.x < 180 && worldRot.x > 0){
			world.transform.RotateAround (pivot, world.transform.right, -worldSpeed * Time.deltaTime);
		}
		if(worldRot.z > 180){
			world.transform.RotateAround (pivot, world.transform.forward, worldSpeed * Time.deltaTime);
		}else if(worldRot.z < 180 && worldRot.z > 0){
			world.transform.RotateAround (pivot, world.transform.forward, -worldSpeed * Time.deltaTime);
		}

		Vector3 temp = world.transform.eulerAngles;
		temp.y = 0;
		world.transform.eulerAngles = temp;
	}
}