using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
public class timer : MonoBehaviour {
	public Text timez; 
	float myTimer; 
	// Use this for initialization
	void Start () {
		myTimer = 12f; 
	}
	
	// Update is called once per frame
	void Update () {
		timez.text = (System.Math.Round (myTimer)).ToString ();
		myTimer -= Time.deltaTime; 
	}
}
