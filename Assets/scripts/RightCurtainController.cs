using UnityEngine;
using System.Collections;

public class RightCurtainController : MonoBehaviour {

	public Transform curtains;
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
			curtains.position+=new Vector3(accelerator, 0f, 0f);			
			accelerator+= .01f;
		}

	}
}
