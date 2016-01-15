using UnityEngine;
using System.Collections;
//fix jump shit
public class Jump : MonoBehaviour {
	public float jumpSpeed = 0f;
	private float jumpStrength = 0f;
	private bool jumping = false;
	private float keyDownTime, keyUpTime;

	Rigidbody rbody; 
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> (); 
	}
	//x+=(target-x)*0.5f

	// Update is called once per frame
	void Update () {
		//Debug.Log (rbody.velocity); 
		if (Input.GetKey (KeyCode.Space) && !jumping) {
			jumpStrength += (jumpSpeed - jumpStrength) * 0.2f;
		
		}
		if (Input.GetKeyUp (KeyCode.Space) && !jumping) {
			float modJumpStrength = jumpStrength / Time.timeScale; 
			if (modJumpStrength > 15) {
				modJumpStrength = 15; 
			}
			rbody.velocity = (new Vector3 (0f, modJumpStrength, 0f));
			jumpStrength = 0f;
			jumping = true;
			//Debug.Log (jumpStrength);


		}
		if (transform.position.x <= -14.63f){
			Application.LoadLevel ("gameOver"); 
		}
	}
	void OnCollisionEnter (Collision collide){
		if (collide.gameObject.tag == "floor") {
			jumping = false; 
		}
		
	}

	
}
