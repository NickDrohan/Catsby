using UnityEngine;
using System.Collections;

public class timetest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse1)) {
			Time.timeScale += (.1f - Time.timeScale) * .01f;
		}
		else if (Time.timeScale <1 ){
			Time.timeScale += (1f - Time.timeScale) * .01f;
		}
		if (Input.GetKey (KeyCode.Mouse0)) {
			Time.timeScale += (4f - Time.timeScale) * .05f;
		} 
		else if (Time.timeScale > 1) {
			Time.timeScale += (1f - Time.timeScale) * .05f;
		}
	}
}
