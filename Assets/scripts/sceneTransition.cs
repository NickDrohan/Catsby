using UnityEngine;
using System.Collections;

public class sceneTransition : MonoBehaviour {
	public Transform marker; 
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if ((marker.position - transform.position).magnitude < 5f && Input.GetKeyDown (KeyCode.E)) {
			Application.LoadLevel ("alley"); 

		}
	}
}
