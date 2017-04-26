using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

	public bool SwitchOn = false;	// Current state of switch
	public GameObject[] Lights;		// Array of light objects

	// Move switch to right position
	void Start() {
		PositionSwitch ();
	}

	// If this gameobject is clicked...
	void OnMouseUp() {
		// Toggle Switch state
		SwitchOn = !SwitchOn;

		// Play click sound
		this.GetComponent<AudioSource> ().Play ();

		// Tilt switch
		PositionSwitch ();

		// Set lights on / off
		SetLights ();
	}

	// To position switch, make 10 degree change on rotation
	void PositionSwitch() {
		if (SwitchOn) 
			transform.rotation = Quaternion.Euler(-85f,0,0);
		else
			transform.rotation = Quaternion.Euler(-95f,0,0);
	}

	// Go thru light objects and toggle light
	void SetLights() {
		foreach(GameObject light in Lights) {
			light.GetComponent<Light> ().enabled = !light.GetComponent<Light> ().enabled;
		}
	}

}
