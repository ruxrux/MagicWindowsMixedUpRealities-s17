using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.iOS;


public class ARKHit : MonoBehaviour {

	public GameObject aPrefab;
	GameObject hitObject;

	// Use this for initialization
	void Start () {
		hitObject = Instantiate<GameObject> (aPrefab);
	}


	void onHit(ARPoint point){

		// prioritize the results
		ARHitTestResultType[] resultTypes = {
			//ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent,
			//ARHitTestResultType.ARHitTestResultTypeExistingPlane,
			ARHitTestResultType.ARHitTestResultTypeHorizontalPlane,
			ARHitTestResultType.ARHitTestResultTypeFeaturePoint,
			//ARHitTestResultType.ARHitTestResultTypeVerticalPlane

		};

		foreach(ARHitTestResultType resultType in resultTypes){
			List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultType);

			if (hitResults.Count > 0) {

				foreach(var hitResult in hitResults){
					Debug.Log ("GOT HIT!!!");
					hitObject.transform.position = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
					hitObject.transform.rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
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

				onHit (point);
			}
		}
	}
}
