using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://docs.unity3d.com/ScriptReference/Physics.Raycast.html

public class RaycastLook : MonoBehaviour {

	public Transform origin;		// public var to get the ray's origin  
	private float rayReach = 3.0f; // the length of the ray 

	// Update is called once per frame
	void Update () {
		// var to store the  hit object's info
		RaycastHit hit;
		// to ray cast you need :  an origin 		   + direction			   + a var to store the hit object's data 
		if( Physics.Raycast(origin.transform.position, origin.transform.forward, out hit, rayReach) ){

			// we dont want to count the plane as a hit
			if (hit.collider.name != "Plane") {

				Debug.Log (hit.collider.name + " > " + hit.distance);
				//Debug.Log (hit.collider.tag);

				// find the object and call its Animate() function
				GameObject.Find (hit.collider.name).SendMessage ("Animate");

				// https://docs.unity3d.com/ScriptReference/GameObject.SendMessage.html
				// if the  object's function you're calling has parameters < e.g. void Animate(float speed) > 
				// you have to pass them < e.g. SendMessage("Animate", 1.0f) >
				// you can also find the object through a tag
				// GameObject.FindGameObjectWithTag ("tag").SendMessage ("Animate");
				// or multiple objects if they have the same tag
				// GameObject.FindGameObjectsWithTag ...
			}
		}
	}
}
