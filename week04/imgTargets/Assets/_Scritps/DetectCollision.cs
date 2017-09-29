using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("collided with :: " + col.gameObject.name); 

		Renderer rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("Standard");
		rend.material.SetColor("_Color", Color.green);

//		if(col.gameObject.name == "???")
//		{
//			// do something
//		}

	}
}
