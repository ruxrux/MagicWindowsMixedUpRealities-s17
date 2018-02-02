using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtMe : MonoBehaviour {

	public Transform target;

	// Update is called once per frame
	void Update () {
		this.transform.LookAt (target);
	}
}
