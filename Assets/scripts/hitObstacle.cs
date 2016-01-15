using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
public class hitObstacle : MonoBehaviour {
	public Text xText; 
	Rigidbody rbody; 
	int count = 3; 
	// Use this for initialization
	void Start () {
		xText.text = "X X X"; 
		rbody = GetComponent<Rigidbody> (); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collide){
		if (collide.gameObject.tag == "obstacle") {
			//move object back and up a lil
			GameObject.Destroy(collide.gameObject); 
			count --; 
			if (count == 2){
				xText.text = "X X";
			}
			else if (count == 1){
				xText.text = "X"; 
			}
			else {
				//game over 
				Application.LoadLevel("gameOver"); 
			}
		}
		if (collide.gameObject.tag == "health") {
			GameObject.Destroy (collide.gameObject);
			count ++; 
			if (count == 2){
				xText.text = "X X"; 

			}
			else if (count == 3){
				xText.text = "X X X"; 
			}
		}

	}
}
