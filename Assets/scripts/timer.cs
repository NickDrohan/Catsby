using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
public class timer : MonoBehaviour {
	public Text timez; 
	float myTimer; 
	public Image catClock;
	float originalTime;

	// Use this for initialization
	void Start () {
		myTimer = 12f; 
		originalTime = myTimer; 
	}
	
	// Update is called once per frame
	void Update () {
		timez.text = (myTimer.ToString ());
		catClock.fillAmount = myTimer/originalTime; 
		myTimer -= Time.deltaTime; 
		if (myTimer <= 0) {
			//end game
			Application.LoadLevel ("gameOver"); 
		}
	}
}
