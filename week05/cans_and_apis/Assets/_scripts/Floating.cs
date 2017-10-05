using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, .1f + (Mathf.Sin(Time.time *2) *.04f), transform.position.z);
	}
}
