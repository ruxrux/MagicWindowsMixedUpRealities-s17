using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.iOS;

public class basicEnvLighting : MonoBehaviour {

	// Use this for initialization
	void Start () {

		UnityARSessionNativeInterface.ARFrameUpdatedEvent += UpdateAmbientIntensity;
	}
	
	void UpdateAmbientIntensity (UnityARCamera cam) {
		// convert ARKIT Intensity 
		// arkit 0 - 2000
		// unity 0 - 8 //cam.lightEstimation.ambientIntensity
		float scaledLight = cam.lightData.arLightEstimate.ambientIntensity / 1000f;
		RenderSettings.ambientLight = Color.white * scaledLight;
	}
}
