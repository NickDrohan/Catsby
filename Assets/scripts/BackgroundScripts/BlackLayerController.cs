using UnityEngine;
using System.Collections;

public class BlackLayerController : MonoBehaviour {

	public float scrollSpeed;
	private Vector3 startPosition;
	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3(scrollSpeed,0f,0f);
	}
}
