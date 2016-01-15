using UnityEngine;
using System.Collections;

public class detectHit : MonoBehaviour {
	bool hitObs = false; 
	public Transform playr; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!hitObs && playr.position.x > transform.position.x) {

		}
	}
	void OnCollisionEnter(Collision collide){
		if (collide.gameObject.tag == "player") {
			hitObs = true; 
		}



	}
}
