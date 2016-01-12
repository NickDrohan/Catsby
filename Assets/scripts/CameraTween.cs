using UnityEngine;
using System.Collections;

public class CameraTween : MonoBehaviour {
	public Transform player; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3((player.position.x - transform.position.x) * 0.1f, 0f, 0f);
	}
}
