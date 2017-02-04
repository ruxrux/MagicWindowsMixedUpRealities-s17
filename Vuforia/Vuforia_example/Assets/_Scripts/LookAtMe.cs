using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMe : MonoBehaviour {

	// transform from the object we want to be looking at
	public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// use the target coordinates to rotate this object
		this.transform.LookAt(target);

	}
}
