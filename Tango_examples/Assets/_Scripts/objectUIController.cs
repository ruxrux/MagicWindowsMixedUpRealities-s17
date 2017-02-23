using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectUIController : MonoBehaviour {

	// public for our objects
	public GameObject myObject;
	private TangoPointCloud pointCloud;


	// Use this for initialization
	void Start () {
		// find our Tango point cloud and attach it to our pc object
		pointCloud = FindObjectOfType<TangoPointCloud>();
	}
	
	// Update is called once per frame
	void Update () {

		// if we only have on touch - disregard multitouch
		if(Input.touchCount == 1){

			// get the touch position
			Touch t = Input.GetTouch(0);

			// place object on touch position when touch ended
			if(t.phase == TouchPhase.Ended){
				PlaceObject (t.position);
			}
		}
	}

	void PlaceObject(Vector2 _touchPos){

		// Find the plane
		Camera cam = Camera.main;
		// vector3 for the plance center pos
		Vector3 planeCenter;
		// plane to store the found plane
		Plane plane;
		// looks for planes - only continue if it has found a plane
		if(!pointCloud.FindPlane(cam, _touchPos, out planeCenter, out plane )){
			Debug.Log ("Can't find plane...");
			return;
		}

		// if it has found a plane, now we can use it to place our object
		// first make sure the plane isnt at a steep angle
		if (Vector3.Angle (plane.normal, Vector3.up) < 30.0f) {

			// find up, right and forward
			Vector3 up = plane.normal;
			Vector3 right = Vector3.Cross (plane.normal, cam.transform.forward).normalized;
			Vector3 forward = Vector3.Cross (right, plane.normal).normalized;

			// add, Instantiate our object on the scene 
			Instantiate (myObject, planeCenter, Quaternion.LookRotation (forward, up));
		} else {
			Debug.Log ("surface is too steep");
		}


	}
}
