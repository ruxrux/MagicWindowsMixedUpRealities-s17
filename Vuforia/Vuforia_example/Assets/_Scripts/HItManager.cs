using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HItManager : MonoBehaviour {

	private RaycastHit hit;

	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if(Physics.Raycast(ray, out hit) && Input.GetMouseButton(0) && hit.transform.tag == "fake"){
			Debug.Log ("HIT!!!!");
			hit.transform.gameObject.SendMessage ("OnPoke");
		}
	}
}

