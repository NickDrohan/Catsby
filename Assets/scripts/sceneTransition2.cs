using UnityEngine;
using System.Collections;

public class sceneTransition2 : MonoBehaviour {
	public Transform marker; 
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		if ((marker.position - transform.position).magnitude < 2f && Input.GetKeyDown (KeyCode.E)) {
			Application.LoadLevel ("cloudScene"); 
			
		}
	}
}
