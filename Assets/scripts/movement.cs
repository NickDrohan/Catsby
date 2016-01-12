using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	
	public float Speed = 0f; 
	private float movex = 0f;
	//private float movey = 0f;
	Rigidbody rbody; 
	
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> (); 
	}
	
	void Update () {
		//if (Input.GetKeyDown (KeyCode.Space)) {
			//transform.position += new Vector3(0f, 4f, 0f); 
		//}
		
	}
	// Update is called once per frame
	void FixedUpdate () {

		movex = Input.GetAxis ("Horizontal");
		Debug.Log (movex); 
		//movey = Input.GetAxis ("Vertical");
		rbody.velocity = new Vector3 (movex * Speed, rbody.velocity.y, 0f);
	}
}

