using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectUIController : MonoBehaviour {

	// public array for our objects
	public GameObject [] myObject;

	private TangoPointCloud pointCloud;


	// Use this for initialization
	void Start () {
		// find our Tango point cloud and attach it to our pc object
		pointCloud = FindObjectOfType<TangoPointCloud>();
	}
	
	// Update is called once per frame
	void Update () {

		// count only first touch - disregard following finger touches
		if(Input.touchCount == 1){

			// get the touch position
			Touch t = Input.GetTouch(0);

			// place object on touch position when touch ended
			if(t.phase == TouchPhase.Ended){
				PlaceObject (t.position, "FRONTOF");
			}
		}
	}

	void PlaceObject(Vector2 _touchPos, string _mode){

		Camera cam = Camera.main;

		if (_mode == "FRONTOF") {
			// IN FRONT OF

		// Instantiate our object on the scene right on front of our camera
		Vector3 frontPOS  = cam.transform.position + cam.transform.forward * .5f;
			Instantiate (myObject[Random.Range(0,myObject.Length)], frontPOS, Quaternion.identity);

		} else if (_mode == "POINTS") {
			// FIND POINTS //

			// FindClosestPoint() is a very intensive function as it goes through every single point in the pc - ideally called no more than once per frame
			int pointIndex = pointCloud.FindClosestPoint (cam, _touchPos, 10);

			if (pointIndex > -1) {
				// Index is valid
				Vector3 pos = pointCloud.m_points [pointIndex];
				// add, Instantiate our object on the scene 
				Instantiate (myObject [Random.Range (0, myObject.Length)], pos, Quaternion.LookRotation (cam.transform.forward, cam.transform.up));
			}

		} else if (_mode == "PLANES") {
		// FIND PLANES //

		// vector3 to store the plance center pos
		Vector3 planeCenter;
		// plane primitive to store the found plane
		Plane plane;

		// look for planes - only continue if a plane has been found
		if(!pointCloud.FindPlane(cam, _touchPos, out planeCenter, out plane )){
			Debug.Log ("Can't find plane...");
			return;
		}

		// if it has found a plane, now we can use it to place our object
		// first make sure the plane isnt at a steep angle i.e.
//		if (Vector3.Angle (plane.normal, Vector3.up) < 30.0f) {

		// find up, right and forward
		Vector3 up = plane.normal;
		Vector3 right = Vector3.Cross (plane.normal, cam.transform.forward).normalized;
		Vector3 forward = Vector3.Cross (right, plane.normal).normalized;

			// add, Instantiate our object on the scene 
		Instantiate (myObject[Random.Range(0,myObject.Length)], planeCenter, Quaternion.LookRotation (forward, up));
//		} else {
//			Debug.Log ("surface is too steep");
//		}

		}
	}
}
