using UnityEngine;
using System.Collections;

public class RightCurtainController : MonoBehaviour {

	public Transform rightCurtains;
	float accelerator=.01f;
	public float rightLimit; 
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
			rightCurtains.position+=new Vector3(accelerator, 0f, 0f);			
			accelerator+= .01f;
		}
		if (transform.position.x >= rightLimit && LeftCurtainController.leftOpen) {
			//start coroutine
			StartCoroutine(NickIsCute()); 

			LeftCurtainController.leftOpen = false; 
		}
	}
	IEnumerator NickIsCute(){
		Debug.Log ("Coroutine started"); 
		yield return new WaitForSeconds(5f); 
		Debug.Log ("Done waiting"); 
		Application.LoadLevel ("lucyFirstScene"); 
	}
}
