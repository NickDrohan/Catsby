using UnityEngine;
using System.Collections;

public class LeftCurtainController : MonoBehaviour {

	public Transform leftCurtain; 
	public float leftLimit; 
	public static bool leftOpen = false; 
	float accelerator=.01f;
	bool clicked=false;

	// Use this for initialization
	void Start () {
	
	}

	public void onClick(){

		clicked = true;
	}

	// Update is called once per frame
	void Update () {

		if (clicked) {
			leftCurtain.position -= new Vector3 (accelerator, 0f, 0f);			
			accelerator += .01f;
			Debug.Log ("Left should move"); 
		}
		if (leftCurtain.position.x <= leftLimit) {
			leftOpen = true; 
			Debug.Log (leftOpen); 
		}
	

	}
}
