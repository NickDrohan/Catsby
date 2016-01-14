using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthController : MonoBehaviour {


	void Start(){
		Image image = GetComponent<Image>();
		image.fillAmount = 1;
	}

	void Update () {

		Image image = GetComponent<Image>();

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			image.fillAmount += (0 - image.fillAmount) * .05f;
		}
	}
}
