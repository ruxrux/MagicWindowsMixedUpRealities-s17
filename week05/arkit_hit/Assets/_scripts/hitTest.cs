using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.iOS; // using arkit namespace

public class hitTest : MonoBehaviour {

	// text for debug
	//public Text debugTxt;

	//add public to link augmentable prefab
	//create object to put it on
	public GameObject hitPrefab; // augmentable we will replicate on each hit test
	GameObject hitObject;			
	AudioSource sample;

	void Start(){
		//instantiate prefab 
		hitObject = Instantiate<GameObject> (hitPrefab);
		sample = hitObject.GetComponent<AudioSource> ();

		//debugTxt.text = "Starting... ";// + sample.name;

	}


	void onHit(ARPoint point){

		// prioritize the results
		ARHitTestResultType[] resultTypes = {
			ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent,
			ARHitTestResultType.ARHitTestResultTypeExistingPlane,
			ARHitTestResultType.ARHitTestResultTypeHorizontalPlane,
			ARHitTestResultType.ARHitTestResultTypeFeaturePoint
			//ARHitTestResultType.ARHitTestResultTypeVerticalPlane,

		};

		foreach(ARHitTestResultType resultType in resultTypes){
			List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultType);

			if (hitResults.Count > 0) {

				foreach(var hitResult in hitResults){
					//Debug.Log ("GOT HIT!!!");
					//debugTxt.text = "got hit!";

					hitObject.transform.position = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
					hitObject.transform.rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
					sample.Play ();
				}

			}
		}

	}


	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {
			var touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved) {
				var screenPosition = Camera.main.ScreenToViewportPoint (touch.position);
				ARPoint point = new ARPoint {
					x = screenPosition.x,
					y = screenPosition.y
				};

				//debugTxt.text = "got touch";
				// do a hit test
				// lets test if we hit a desired surface/feature and add an object
				onHit (point);
			}
		}
	}
}


