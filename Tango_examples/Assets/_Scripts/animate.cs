using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour {
	
	// Update is called once per frame
	void Animate() {

		this.transform.position = new Vector3 (this.transform.position.x, 1f + Mathf.Sin(Time.time * .2f) * .3f, this.transform.position.z );

	}
}
