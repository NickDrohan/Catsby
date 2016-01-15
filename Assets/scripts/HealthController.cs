using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthController : MonoBehaviour {
	Collision collide; 
	float numOfObstacles; 

	void Start(){
		Image image = GetComponent<Image>();
		image.fillAmount = 1;
		numOfObstacles = 4f; 
	}

	void Update () {

		Image image = GetComponent<Image>();

		//if (detectHit.loseHealth || Input.GetKeyDown (KeyCode.Mouse1)) {
			//Debug.Log ("I should be going down now"); 
			//image.fillAmount += (0 - image.fillAmount) * .05f;
			//detectHit.loseHealth = false; 
		image.fillAmount = detectHit.loseAmount / numOfObstacles; 
		if (detectHit.loseAmount <= 0) {

			Application.LoadLevel("winScreen"); 
		}
		//}
	}
}
