using UnityEngine;
using System.Collections;

public class detectHit : MonoBehaviour {
	bool hitObs = false; 
	bool alreadyChecked = false; 
	public Transform playr; 
	public static float loseAmount;
	// Use this for initialization
	void Start () {
		loseAmount = 4f; 
	}
	
	// Update is called once per frame
	void Update () {
		if (!hitObs && playr.position.x > transform.position.x && !alreadyChecked) {
			Debug.Log ("Now I should lose health..."); 
			loseAmount --; 
			alreadyChecked = true; 
		}
	}
	void OnCollisionEnter(Collision collide){
		if (collide.gameObject.tag == "player") {
			hitObs = true; 
			Debug.Log ("Hit you nanananana"); 
	
		}



	}
}
