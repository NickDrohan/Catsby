using UnityEngine;
using System.Collections;

public class objMovement : MonoBehaviour {

	Rigidbody rbody; 

	void Start () {
		rbody = GetComponent<Rigidbody>(); 
	}
	// Update is called once per frame
	void FixedUpdate () {
		rbody.velocity = (new Vector3 (-10f, 0f, 0f)); 
	}
}
