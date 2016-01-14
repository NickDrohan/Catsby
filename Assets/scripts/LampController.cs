using UnityEngine;
using System.Collections;

public class LampController : MonoBehaviour {

	Rigidbody rbody;
	private Vector3 startPosition;

	void Start () {
		startPosition = transform.position;
		rbody = GetComponent<Rigidbody>(); 
	}
	// Update is called once per frame
	void FixedUpdate () {
		rbody.velocity = (new Vector3 (-5f, 0f, 0f));
		if (rbody.position.x < -20)
			transform.position = startPosition + Vector3.right * 10;
	}
}
