using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {


	Rigidbody body;
	public float strenght;
	public Camera cam;
	public int jumpforce;

	// Use this for initialization
	void Start () {
		body = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		float hori;
		float vert;

		Vector3 input = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis ("Vertical"));
		input *= strenght;

		input = cam.transform.TransformDirection (input);

		input.y = 0;

		body.AddForce (input);

		if (Input.GetKeyDown ("space")) {
			body.velocity = new Vector3(0, jumpforce, 0);
		}
	}
}
