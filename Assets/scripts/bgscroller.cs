using UnityEngine;
using System.Collections;

public class bgscroller : MonoBehaviour
{
	public float scrollSpeed;
 	float tileSizeX;
	private Vector3 startPosition;
	
	void Start ()
	{
		startPosition = transform.position;
		tileSizeX = GetComponent<Renderer> ().bounds.size.x;
	}
	
	void Update ()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeX);
		transform.position = startPosition + Vector3.left * newPosition;
	}
}