using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;

public class envLighting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UnityARSessionNativeInterface.ARFrameUpdatedEvent += UpdatedAmbientIntensity;
	}

	void UpdatedAmbientIntensity (UnityARCamera camera)
	{
		float newLight = camera.lightData.arLightEstimate.ambientIntensity /1000f;
		RenderSettings.ambientLight = Color.white * newLight;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
