using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour {

	public bool flickerEnabled;
	public float minTimeOn = 0.05f;
	public float maxTimeOn = 0.1f;

	private Light lightComponent;
	private float counter;

	void Start () {
		lightComponent = GetComponent<Light>();
		counter = Random.Range(minTimeOn, maxTimeOn);
	}

	void Update () {
		counter -= Time.deltaTime;

		if(counter <= 0 && lightComponent.enabled && flickerEnabled) {
			float intensity = Random.Range (0f, 1f);
			lightComponent.intensity = intensity;
			counter = Random.Range(minTimeOn, maxTimeOn);
		}
	}
}
